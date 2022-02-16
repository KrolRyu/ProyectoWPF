using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.Servicios
{
    /// <summary>
    /// Clase para sacar la edad y el genero de una persona a partir de la imagen
    /// </summary>
    static class ServicioComprobarCara
    {

        /// <summary>
        /// Método encargado de gestionar la comprobacion de la cara
        /// </summary>
        /// <param name="imagen">
        /// URL de la imagen en Azure
        /// </param>
        /// <returns>
        /// Devuelve una clase con los campos de edad y genero
        /// </returns>
        public static FaceAttributes ComprobarCara(string imagen)
        {
            var response = PostCara(imagen);
            Root[] respuesta = JsonConvert.DeserializeObject<Root[]>(response.Content);
            return respuesta[0].faceAttributes;
        }


        /// <summary>
        /// Método que manda la imagen a la API y recibe la respuesta
        /// </summary>
        /// <param name="imagen">
        /// URL de la imagen en Azure
        /// </param>
        /// <returns>
        /// Devuelve la respuesta de la API
        /// </returns>
        public static IRestResponse PostCara(string imagen)
        {
            var client = new RestClient(Properties.Settings.Default.EndpointIACara);
            var request = new RestRequest("detect", Method.POST);
            string data = "{ 'url':'" + imagen + "'}";
            request.AddHeader("Ocp-Apim-Subscription-Key", Properties.Settings.Default.LicenseKeyIACara);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(data);
            request.AddParameter("returnFaceAttributes", "age, gender", ParameterType.QueryString);
            var response = client.Execute(request);
            return response;
        }

        /// <summary>
        /// Clase con informacion de las dimensiones de la cara
        /// </summary>
        public class FaceRectangle
        {
            public int top { get; set; }
            public int left { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        /// <summary>
        /// Clase con la informacion de edad y genero
        /// </summary>
        public class FaceAttributes
        {
            public string gender { get; set; }
            public double age { get; set; }
        }


       /// <summary>
       /// Clase que contiene las clases con la informacion sobre la cara
       /// </summary>
        public class Root
        {
            public string faceId { get; set; }
            public FaceRectangle faceRectangle { get; set; }
            public FaceAttributes faceAttributes { get; set; }
        }
    }
}
