// ***********************************************************************
// Assembly         : QuasarFireOperation.IC
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="ConvertidorLista.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.IC.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// Clase que permite mapear a una lista concreta a traves de un JsonConverter
    /// </summary>
    /// <typeparam name="TC">Clase generica concreta</typeparam>
    /// <typeparam name="TA">Clase generica abstracta</typeparam>
    public class ConvertidorLista<TC, TA> : JsonConverter where TC : TA
    {
        /// <summary>
        /// Metodo de sobrescritura para conocer si un valor se puede convertir
        /// </summary>
        /// <param name="objectType">Objeto de tipo generico</param>
        /// <returns>retorna un valor si</returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(IList<TA>));
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
            IList<TC> items = serializer.Deserialize<List<TC>>(reader);
            if (items == null)
            {
                return new List<TC>().Cast<TA>().ToList();
            }

            return items.Cast<TA>().ToList();
        }

        /// <summary>
        /// Metodo para escribir sobre la clase concreta
        /// </summary>
        /// <param name="writer">parametro de tipo JsonWriter</param>
        /// <param name="value">parametro de tipo object</param>
        /// <param name="serializer">parametro de tipo JsonSerializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value, typeof(IList<TC>));
        }
    }
}