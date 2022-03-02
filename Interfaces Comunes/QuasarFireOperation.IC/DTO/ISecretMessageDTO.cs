// ***********************************************************************
// Assembly         : QuasarFireOperation.IC
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="ISecretMessageDTO.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.IC.DTO
{

    /// <summary>
    /// Declara las propiedades para la entidad ISecretMessageDTO
    /// </summary>
    public interface ISecretMessageDTO
    {
        /// <summary>
        /// Obtiene o establece un valor para Position
        /// </summary>
        IDistancesDTO Position { get; set; }

        /// <summary>
        /// Obtiene o establece un valor para Message
        /// </summary>
        string Message { get; set; }
    }
}