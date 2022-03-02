// ***********************************************************************
// Assembly         : QuasarFireOperation.API
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="SatellitesPositionMessage.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.API.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using QuasarFireOperation.IC.DTO;
    using QuasarFireOperation.IC.Utilities;

    /// <summary>
    /// Clase que implementa las propiedades de la entidad SatellitesPositionMessage
    /// </summary>
    public class SatellitesPositionMessage : ISatellitesPositionMessageDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para Satellites
        /// </summary>
        [JsonConverter(typeof(ConvertidorLista<Satellites, ISatellitesDTO>))]
        public List<ISatellitesDTO> Satellites { get; set; }
    }
}
