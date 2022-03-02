// ***********************************************************************
// Assembly         : QuasarFireOperation.BL
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="TopSecretBL.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.Negocio.Clases.BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using QuasarFireOperation.IC.Acciones;
    using QuasarFireOperation.IC.DTO;
    using QuasarFireOperation.Negocio.Clases.BO;

    /// <summary>
    /// Clase que implementa las acciones del contrato ITopSecretAction
    /// </summary>
    public class TopSecretBL : ITopSecretAction
    {
        #region Atributos

        /// <summary>
        /// Parametro de tipo IDistancesDTO
        /// </summary>
        private IDistancesDTO kenobi;

        /// <summary>
        /// Parametro de tipo IDistancesDTO
        /// </summary>
        private IDistancesDTO skywalker;

        /// <summary>
        /// Parametro de tipo IDistancesDTO
        /// </summary>
        private IDistancesDTO sato;

        #endregion Atributos

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase TopSecretBL
        /// </summary>
        public TopSecretBL()
        {
            this.kenobi = new DistancesBO { X = -500, Y = -200 };
            this.skywalker = new DistancesBO { X = 100, Y = -100 };
            this.sato = new DistancesBO { X = 500, Y = 100 };
        }

        #endregion Constructor

        #region Metodos publicos

        /// <summary>
        /// Metodo para accesder a la localizacion y el mensaje
        /// </summary>
        /// <param name="satellitesPositionMessage">Parametro de tipo ISatellitesPositionMessageDTO</param>
        /// <returns>retorno de tipo IActionResult</returns>
        public IActionResult GetPositionAndMessage(ISatellitesPositionMessageDTO satellitesPositionMessage)
        {
            string message = string.Empty;
            SecretMessageBO secretMessage = new SecretMessageBO();

            if (satellitesPositionMessage.Satellites.Count < 3 || satellitesPositionMessage.Satellites.Select(x => x.Message).ToList().Count < 3)
            {
                return new BadRequestResult();
            }

            List<List<string>> messageList = satellitesPositionMessage.Satellites.Select(x => x.Message).ToList();

            float[] distances = satellitesPositionMessage.Satellites.Select(d => d.Distance).ToArray();

            message = this.GetMessage(messageList);

            IDistancesDTO distance = this.GetLocation(distances);

            if (string.IsNullOrEmpty(message) || distance == null)
            {
                return new NotFoundResult();
            }

            secretMessage.Message = message;
            secretMessage.Position = distance;

            return new OkObjectResult(secretMessage);
        }

        #endregion Metodos publicos

        #region Metodos Privados

        /// <summary>
        /// metodo para determinar el mensaje
        /// </summary>
        /// <param name="messages">parametro de lista de tipo lista de strings</param>
        /// <returns>cadena del mensaje</returns>
        public string GetMessage(List<List<string>> messages)
        {
            try
            {
                string messagePart;
                if (messages.Count < 3) return string.Empty;
                List<string> phrasesList = new List<string>();
                for (int i = 0; i < messages.Count; i++)
                {
                    List<string> array1 = messages[i];
                    for (int j = 0; j < array1.Count; j++)
                    {
                        messagePart = array1[j];
                        if (string.IsNullOrEmpty(messagePart))
                        {
                            for (int k = 0; k < messages.Count; k++)
                            {
                                messagePart = messages[k][j];
                                if (!string.IsNullOrEmpty(messagePart)) break;
                            }
                        }
                        phrasesList.Add(messagePart);
                    }
                    if (phrasesList.Count == array1.Count) break;
                }

                return String.Join(" ", phrasesList);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Metodo para dermitar la localizacion
        /// </summary>
        /// <param name="distance">parametro de tipo float[]</param>
        /// <returns>retorna entidad IDistancesDTO</returns>
        public IDistancesDTO GetLocation(float[] distance)
        {
            try
            {
                if (distance.Length < 3) return null;
                double a = -2 * this.kenobi.X + 2 * this.skywalker.X;
                double b = -2 * this.kenobi.Y + 2 * this.skywalker.Y;
                double c = Math.Pow(distance[0], 2) - Math.Pow(distance[1], 2) - Math.Pow(this.kenobi.X, 2) + Math.Pow(this.skywalker.X, 2) - Math.Pow(this.kenobi.Y, 2) + Math.Pow(this.skywalker.Y, 2);

                double e = -2 * this.skywalker.X + 2 * this.sato.X;
                double f = -2 * this.skywalker.Y + 2 * this.sato.Y;
                double g = Math.Pow(distance[1], 2) - Math.Pow(distance[2], 2) - Math.Pow(this.skywalker.X, 2) + Math.Pow(this.sato.X, 2) - Math.Pow(this.skywalker.Y, 2) + Math.Pow(this.sato.Y, 2);

                double d = a * f - b * e;

                double dx = c * f - b * g;
                double dy = a * g - c * e;
                float x = (float)Math.Round(dx / d, MidpointRounding.AwayFromZero);
                float y = (float)Math.Round(dy / d, MidpointRounding.AwayFromZero);
                return new DistancesBO { X = x, Y = y };
            }
            catch
            {
                return null;
            }
        }

        #endregion Metodos Privados
    }
}