using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.servicios
{
    class ServicioDetectarVehiculo
    {
        String predictionKey = "1d14987690a64deda0d17d7790d49cea";
        String endpoint = "https://customvisionproyectoparkingdint-prediction.cognitiveservices.azure.com/customvision/";
        String projectID = "768c2adc-d877-4c94-908a-847930e8426a";
        String publishedName = "Iteration1";

        // En desarrollo
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
}
