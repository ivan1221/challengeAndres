// ***********************************************************************
// Assembly         : QuasarFireOperation.IC
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="ISatellitesPositionMessageDTO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.IC.DTO
{
    using System.Collections.Generic;

    /// <summary>
    /// Declara las propiedades de la clase ISatellitesPositionMessageDTO
    /// </summary>
    public interface ISatellitesPositionMessageDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para Satellites
        /// </summary>
        List<ISatellitesDTO> Satellites { get; set; }
    }
}