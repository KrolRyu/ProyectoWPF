using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Blobs;

namespace ProyectoParking.Servicios
{
    static class ServicioImgs
    {
        public static String SubirImagenAAzure(string rutaImagen)
        {
            try
            {
                //Cambiar a la configuracion del proyecto
                string cadenaDeConexion = "DefaultEndpointsProtocol=https;AccountName=actividadtema5;AccountKey=Plt4O/P0i4coCkog+BsK/FeBXHnz6sTqtlfVW2dXCT8FIkwfO9teD7fCI5rSwbNau2dvcv3Sf9AxmkkUeOyW9A==;EndpointSuffix=core.windows.net";
                string nombreContenedorBlobs = "imgs-proyecto-parking";

                var clienteBlobService = new BlobServiceClient(cadenaDeConexion);
                var clienteContenedor = clienteBlobService.GetBlobContainerClient(nombreContenedorBlobs);
                Stream streamImagen = File.OpenRead(rutaImagen);
                string nombreImagen = Path.GetFileName(rutaImagen);
                clienteContenedor.UploadBlob(nombreImagen, streamImagen);

                var clienteBlobImagen = clienteContenedor.GetBlobClient(nombreImagen);
                string urlImagen = clienteBlobImagen.Uri.AbsoluteUri;
                return urlImagen;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
