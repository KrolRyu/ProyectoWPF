using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.servicios
{
    /// <summary>
    /// Clase del servicio de detectar vehiculo.
    /// Incluye los métodos necesarios para diferenciar entre un coche y una moto.
    /// </summary>
    static class ServicioDetectarVehiculo
    {
        /// <summary>
        /// El  método principal para diferenciar entre coche y moto.
        /// Es el método que se encarga de recoger la respuesta de la API REST y devolver la información necesaria
        /// </summary>
        /// <param name="ruta">
        /// La ruta de la imagen
        /// </param>
        /// <returns>
        /// Devuelve el tipo, coche o moto
        /// </returns>
        public static string ComprobarVehiculo(string ruta)
        {
            var respuesta = PostVehiculo(ruta);
            Root root = JsonConvert.DeserializeObject<Root>(respuesta.Content);
            if (root.Predictions[0].Probability > root.Predictions[1].Probability)
            {
                return root.Predictions[0].TagName;
            }
            else
            {
                return root.Predictions[1].TagName;
            }
        }

        /// <summary>
        /// Hace la peticion a la API REST 
        /// </summary>
        /// <param name="imagen">
        /// Ruta de la imagen
        /// </param>
        /// <returns>
        /// Devuelve la respuesta de la API para que el método de comprobar vehiculo pueda sacar la información de la respuesta
        /// </returns>
        public static IRestResponse PostVehiculo(string imagen)
        {
            var client = new RestClient(Properties.Settings.Default.EndpointIACustomVision);
            var request = new RestRequest(Properties.Settings.Default.MethodIACustomVision, Method.POST);
            string data = "{ 'url':'" + imagen + "'}";
            request.AddHeader("Prediction-Key", Properties.Settings.Default.PredictionKeyIACustomVision);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(data);
            var response = client.Execute(request);
            return response;
        }
    }

    /// <summary>
    /// Es la clase necesaria para deserializar el objeto devuelto en forma de JSON por la API REST
    /// </summary>
    public class Prediction
    {
        public double Probability { get; set; }
        public string TagId { get; set; }
        public string TagName { get; set; }
    }

    public class Root
    {
        public string Id { get; set; }
        public string Project { get; set; }
        public string Iteration { get; set; }
        public DateTime Created { get; set; }
        public List<Prediction> Predictions { get; set; }
    }
}
