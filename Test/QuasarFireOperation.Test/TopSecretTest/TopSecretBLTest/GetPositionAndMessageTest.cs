// ***********************************************************************
// Assembly         : QuasarFireOperation.Test
// Author           : Andrés Camilo Ferreira Rodríguez
// Created          : 12-02-2022
// ***********************************************************************
// <copyright file="GetPositionAndMessageTest.cs" company="MercadoLibreColombia">
//     Copyright (c) MercadoLibreColombia. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace QuasarFireOperation.Test.TopSecretTest.TopSecretBLTest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using QuasarFireOperation.Negocio.Clases.BL;
    using QuasarFireOperation.Negocio.Clases.BO;
    using Xunit;

    /// <summary>
    /// 
    /// </summary>
    public class GetPositionAndMessageTest
    {

        /// <summary>
        /// Metodo test para funcionalidad GetPositionAndMessage de manera Exitosa
        /// </summary>
        [Fact]
        public void GetPositionAndMessage_Exitoso()
        {
            TopSecretBL topSecretBL = new TopSecretBL();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string jsonRequest = File.ReadAllText(string.Format("{0}/TopSecretTest/Mocks/TopSecretMocks/TopSecret_GetPositionAndMessage_Exitoso.json", ruta));
            SatellitesPositionMessageBO satellitesPositionMessageBO = JsonConvert.DeserializeObject<SatellitesPositionMessageBO>(jsonRequest);
            string jsonReqsponse = File.ReadAllText(string.Format("{0}/TopSecretTest/Mocks/TopSecretMocks/TopSecret_GetPositionAndMessage_Response.json", ruta));
            SecretMessageBO secretMessageBO = JsonConvert.DeserializeObject<SecretMessageBO>(jsonReqsponse);
            var response = new OkObjectResult(secretMessageBO);
            IActionResult respuestaCalculo = topSecretBL.GetPositionAndMessage(satellitesPositionMessageBO);
            Assert.True(response.Equals(respuestaCalculo));
        }

        /// <summary>
        /// Metodo para probar el metodo GetMessage exitosa
        /// </summary>
        [Fact]
        public void GetMessage_Exitoso()
        {
            TopSecretBL topSecretBL = new TopSecretBL();
            List<List<string>> asdfaf = new List<List<string>>();
            List<string> lista1 = new List<string> { "este", "", "", "mensaje", "" };
            List<string> lista2 = new List<string> { "","es","","","secreto" };
            List<string> lista3 = new List<string> {"este","","un","",""};
            asdfaf.Add(lista1);
            asdfaf.Add(lista2);
            asdfaf.Add(lista3);
            string response = topSecretBL.GetMessage(asdfaf);
            Assert.Equal("este es un mensaje secreto", response);
        }

        /// <summary>
        /// Metodo para probar el metodo GetMessage con error
        /// </summary>
        [Fact]
        public void GetMessage_Fallido()
        {
            TopSecretBL topSecretBL = new TopSecretBL();
            List<List<string>> asdfaf = new List<List<string>>();
            List<string> lista1 = new List<string> { "este", "", "", "mensaje", "" };
            List<string> lista2 = new List<string> { "", "es", "", "", "secreto" };
            asdfaf.Add(lista1);
            asdfaf.Add(lista2);
            string response = topSecretBL.GetMessage(asdfaf);
            Assert.Equal(string.Empty, response);
        }
    }
}
