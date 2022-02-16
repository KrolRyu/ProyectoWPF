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
            if (root.Predictions[0].Probability > root.Predictions[1].Probability)
            {
                return root.Predictions[0].TagName;
            }
            else
            {
                return root.Predictions[1].TagName;
            }
        }

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
