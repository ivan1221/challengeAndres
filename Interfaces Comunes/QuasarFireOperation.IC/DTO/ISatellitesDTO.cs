// ***********************************************************************
// Assembly         : QuasarFireOperation.IC
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="ISatellitesDTO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.IC.DTO
{
    using System.Collections.Generic;

    /// <summary>
    /// Declara las propiedades para la entidad ISatellitesDTO
    /// </summary>
    public interface ISatellitesDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para Name
        /// </summary>
        string Name {get;set;}

        /// <summary>
        /// Obtiene o establece un valor para Distance
        /// </summary>
        float Distance {get;set;}

        /// <summary>
        /// Obtiene o establece un valor para Message
        /// </summary>
        List<string> Message {get;set;}
    }
}