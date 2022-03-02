// ***********************************************************************
// Assembly         : QuasarFireOperation.API
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="Satellites.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.API.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using QuasarFireOperation.IC.DTO;

    /// <summary>
    /// Clase que implementa las propiedades de la entidad Satellites
    /// </summary>
    public class Satellites : ISatellitesDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece un valor para Distance
        /// </summary>
        public float Distance { get; set; }

        /// <summary>
        /// Obtiene o establece un valor para Message
        /// </summary>
        public List<string> Message { get; set; }
    }
}
