// ***********************************************************************
// Assembly         : QuasarFireOperation.IC
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="ITopSecretAction.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.IC.Acciones
{
    using Microsoft.AspNetCore.Mvc;
    using QuasarFireOperation.IC.DTO;

    /// <summary>
    /// Declara las acciones para la capa de negocio de la clase TopSecret
    /// </summary>
    public interface ITopSecretAction
    {
        /// <summary>
        /// Metodo que retorna la posicion y el mensaje.
        /// </summary>
        /// <param name="satellitesPositionMessage">Parametro de tipo ISatellitesPositionMessageDTO</param>
        /// <returns>Retorno de tipo IActionResult</returns>
        IActionResult GetPositionAndMessage(ISatellitesPositionMessageDTO satellitesPositionMessage);
    }
}