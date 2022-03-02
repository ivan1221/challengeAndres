// ***********************************************************************
// Assembly         : QuasarFireOperation.API
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="TopSecretController.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.API.Controllers
{
    using System.Net.Http;
    using Microsoft.AspNetCore.Mvc;
    using QuasarFireOperation.API.Models;
    using QuasarFireOperation.IC.Acciones;
    using QuasarFireOperation.Negocio.Clases.BL;

    /// <summary>
    /// Implementa las capacidades del controlador TopSecretController
    /// </summary>
    [Route("api/[controller]")]
    public class TopSecretController : ControllerBase
    {

        /// <summary>
        /// Atributo de acceso a la capa de negocio DI
        /// </summary>
        private readonly ITopSecretAction topSecretAction;


        /// <summary>
        /// Inicializa una nueva instancia de la clase TopSecretController
        /// </summary>
        public TopSecretController()
        {
            this.topSecretAction = new TopSecretBL();
        }


        /// <summary>
        /// Capacidad para conocer la posicion y el mensaje
        /// </summary>
        /// <param name="satellitesPositionMessage">parametro de tipo SatellitesPositionMessage</param>
        /// <returns>Retorno de tipo IActionResult</returns>
        [HttpPost]
        public IActionResult GetPositionAndMessage([FromBody] SatellitesPositionMessage satellitesPositionMessage)
        {
            return this.topSecretAction.GetPositionAndMessage(satellitesPositionMessage);
        }
    }
}
