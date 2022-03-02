// ***********************************************************************
// Assembly         : QuasarFireOperation.BL
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="SatellitesBO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.Negocio.Clases.BO
{
    using System.Collections.Generic;
    using QuasarFireOperation.IC.DTO;

    /// <summary>
    /// Implementa las propiedade de la clase SatellitesBO
    /// </summary>
    public class SatellitesBO : ISatellitesDTO
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
