using Newtonsoft.Json;
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
        public static FaceAttributes ComprobarCara(string imagen)
        {
            var response = PostCara(imagen);
            Root[] respuesta = JsonConvert.DeserializeObject<Root[]>(response.Content);
            return respuesta[0].FaceAttributes;
        }

        public static IRestResponse PostCara(string imagen)
        {
            //Cambiar variables a variables de configuracion
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

        //Clases para convertir el JSON
        public class FaceRectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class FaceAttributes
        {
            public string Gender { get; set; }
            public double Age { get; set; }
        }

        public class Root
        {
            public string FaceId { get; set; }
            public FaceRectangle FaceRectangle { get; set; }
            public FaceAttributes FaceAttributes { get; set; }
        }
    }
}
