// ***********************************************************************
// Assembly         : QuasarFireOperation.BL
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="SatellitesPositionMessageBO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.Negocio.Clases.BO
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using QuasarFireOperation.IC.DTO;
    using QuasarFireOperation.IC.Utilities;

    /// <summary>
    /// Implementa las propiedade de la clase SatellitesPositionMessageBO
    /// </summary>
    public class SatellitesPositionMessageBO : ISatellitesPositionMessageDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para Satellites
        /// </summary>
        [JsonConverter(typeof(ConvertidorLista<SatellitesBO, ISatellitesDTO>))]
        public List<ISatellitesDTO> Satellites { get; set; }
    }
}
