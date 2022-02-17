using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoParking.servicios
{
    /// <summary>
    /// Clase para sacar la matricula de un vehiculo
    /// </summary>
    static class ServicioMatricula
    {
        /// <summary>
        /// Método encargado de gestionar las llamadas a la API para sacar la matricula.
        /// Se encarga de recibir las respuestas de las APIs y devuelve la matricula
        /// </summary>
        /// <param name="imagen">
        /// Ruta de la imagen
        /// </param>
        /// <param name="tipo">
        /// El tipo de vehiculo, coche o moto
        /// </param>
        /// <returns>
        /// Devuelve un string con la matricula
        /// </returns>
        public static string SacarMatricula(string imagen, string tipo)
        {
            var response = PostMatricula(imagen);
            string urlGET = response.Headers[0].ToString().Split('=')[1];
            Thread.Sleep(2000);
            return GetMatricula(urlGET, tipo);

        }

        /// <summary>
        /// Sube la imagen al servicio de Azure y devuelve la URL para hacer el GET
        /// </summary>
        /// <param name="imagen">
        /// La URL de la imagen
        /// </param>
        /// <returns>
        /// Devulve la URL para poder hacer el GET
        /// </returns>
        public static IRestResponse PostMatricula(string imagen)
        {
            //Cambiar variables a variables de configuracion
            var client = new RestClient(Properties.Settings.Default.EndpointMatricula);
            var request = new RestRequest(Method.POST);
            string data = "{ 'url':'" + imagen + "'}";
            request.AddHeader("Ocp-Apim-Subscription-Key", Properties.Settings.Default.LicenciaIAMatricula);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(data);
            var response = client.Execute(request);
            return response;
        }


        /// <summary>
        /// Hace el GET al servicio de Azure y saca la matricula del vehiculo
        /// </summary>
        /// <param name="url">
        /// URL de la API REST
        /// </param>
        /// <param name="tipo">
        /// Tipo de vehiculo, coche o moto
        /// </param>
        /// <returns>
        /// Devuelve la matricula del vehiculo
        /// </returns>
        public static string GetMatricula(string url, string tipo)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Ocp-Apim-Subscription-Key", "5b398d14a7424edca5be3158a45093ce");
            var response = client.Execute(request);
            if(tipo == "coche")
            {
                JToken jt = JToken.Parse(response.Content).SelectToken("analyzeResult").SelectToken("readResults").First.SelectToken("lines").First.SelectToken("text");
                return jt.ToString();
            }
            else
            {
                JToken jt = JToken.Parse(response.Content).SelectToken("analyzeResult").SelectToken("readResults").First.SelectToken("lines").First.SelectToken("text");
                JToken jt2 = JToken.Parse(response.Content).SelectToken("analyzeResult").SelectToken("readResults")[1].SelectToken("lines").First.SelectToken("text");
                return jt.ToString() + jt2.ToString();
            }
            
        }
    }
}
