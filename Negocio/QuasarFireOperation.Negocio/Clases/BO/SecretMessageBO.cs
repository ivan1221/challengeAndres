// ***********************************************************************
// Assembly         : QuasarFireOperation.BL
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="SecretMessageBO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.Negocio.Clases.BO
{
    using Newtonsoft.Json;
    using QuasarFireOperation.IC.DTO;
    using QuasarFireOperation.IC.Utilities;

    /// <summary>
    /// Implementa las propiedade de la clase SecretMessageBO
    /// </summary>
    public class SecretMessageBO : ISecretMessageDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para Position
        /// </summary>
        [JsonConverter(typeof(ConvertidorEntidad<DistancesBO, IDistancesDTO>))]
        public IDistancesDTO Position { get; set; }

        /// <summary>
        /// Obtiene o establece un valor para Message
        /// </summary>
        public string Message { get; set; }
    }
}
