// ***********************************************************************
// Assembly         : QuasarFireOperation.BL
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="DistancesBO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.Negocio.Clases.BO
{
    using QuasarFireOperation.IC.DTO;

    /// <summary>
    /// Implementa las propiedade de la clase DistancesBO
    /// </summary>
    public class DistancesBO : IDistancesDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para X
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Obtiene o establece un valor para Y
        /// </summary>
        public float Y { get; set; }
    }
}
