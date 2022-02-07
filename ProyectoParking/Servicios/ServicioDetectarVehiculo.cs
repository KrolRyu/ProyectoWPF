using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.servicios
{
    static class ServicioDetectarVehiculo
    {
        public static string ComprobarVehiculo(string ruta)
        {
            var respuesta = PostVehiculo(ruta);
            Root root = JsonConvert.DeserializeObject<Root>(respuesta.Content);
            if (root.predictions[0].probability > root.predictions[1].probability)
            {
                return root.predictions[0].tagName;
            }
            else
            {
                return root.predictions[1].tagName;
            }
        }

        public static IRestResponse PostVehiculo(string imagen)
        {
            var client = new RestClient("https://customvisionproyectoparkingdint-prediction.cognitiveservices.azure.com/customvision/");
            var request = new RestRequest("v3.0/Prediction/768c2adc-d877-4c94-908a-847930e8426a/classify/iterations/Iteration1/", Method.POST);
            string data = "{ 'url':'" + imagen + "'}";
            request.AddHeader("Prediction-Key", "1d14987690a64deda0d17d7790d49cea");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(data);
            var response = client.Execute(request);
            return response;
        }
    }
    public class Prediction
    {
        public double probability { get; set; }
        public string tagId { get; set; }
        public string tagName { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public string project { get; set; }
        public string iteration { get; set; }
        public DateTime created { get; set; }
        public List<Prediction> predictions { get; set; }
    }
}
