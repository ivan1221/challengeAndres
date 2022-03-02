// ***********************************************************************
// Assembly         : QuasarFireOperation.IC
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="IDistancesDTO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.IC.DTO
{
    /// <summary>
    /// Declara las propiedades para la entidad IDistancesDTO
    /// </summary>
    public interface IDistancesDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para X
        /// </summary>
        float X { get; set; }

        /// <summary>
        /// Obtiene o establece un valor para Y
        /// </summary>
        float Y { get; set; }
    }
}