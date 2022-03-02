// ***********************************************************************
// Assembly         : QuasarFireOperation.IC
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="ConvertidorEntidad.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.IC.Utilities
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Clase que permite mapear a una clase concreta a traves de un JsonConverter
    /// </summary>
    /// <typeparam name="TC">Clase generica concreta</typeparam>
    /// <typeparam name="TA">Clase generica abstracta</typeparam>
    public class ConvertidorEntidad<TC, TA> : JsonConverter where TC : TA
    {
        /// <summary>
        /// Metodo de sobrescritura para conocer si un valor se puede convertir
        /// </summary>
        /// <param name="objectType">Objeto de tipo generico</param>
        /// <returns>retorna un valor si</returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(TA));
        }

        /// <summary>
        /// Metodo que permite leer la estructura del Json
        /// </summary>
        /// <param name="reader">parametro de tipo JsonReader</param>
        /// <param name="objectType">parametro generico de tipo Type</param>
        /// <param name="existingValue">parametro de tipo object</param>
        /// <param name="serializer">parametro de tipo JsonSerializer</param>
        /// <returns>Retorna un valor de tipo object</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<TC>(reader);
        }

        /// <summary>
        /// Metodo para escribir sobre la clase concreta
        /// </summary>
        /// <param name="writer">parametro de tipo JsonWriter</param>
        /// <param name="value">parametro de tipo object</param>
        /// <param name="serializer">parametro de tipo JsonSerializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(TC));
        }
    }
}