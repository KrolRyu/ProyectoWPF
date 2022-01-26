using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.Servicios
{
    static class ServicioComprobarCara
    {
        public static void ComprobarCara(string imagen)
        {
            var response = PostCara(imagen);
            string respuesta = response.Content;
        }

        public static IRestResponse PostCara(string imagen)
        {
            //Cambiar variables a variables de configuracion
            var client = new RestClient("https://servicio-face-proyecto-parking.cognitiveservices.azure.com//face/v1.07/");
            var request = new RestRequest("detect", Method.POST);
            string data = "{ 'url':'[" + imagen + "]'}";
            request.AddHeader("Ocp-Apim-Subscription-Key", "38cac79a9bd04f648466d0b24ad1d9f5");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            request.AddParameter("returnFaceAttributes", "age,gender", ParameterType.QueryString);
            var response = client.Execute(request);
            return response;
    }
    }
}
