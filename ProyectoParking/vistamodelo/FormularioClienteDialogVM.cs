using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.servicios;
using ProyectoParking.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.vistamodelo
{
    class FormularioClienteDialogVM : ObservableObject
    {
        private string rutaImagen;

        public string RutaImagen
        {
            get { return rutaImagen; }
            set { SetProperty(ref rutaImagen, value); }
        }

        public FormularioClienteDialogVM()
        {

        }

        public void ExaminarImagen()
        {
            RutaImagen = ServicioDialogos.ExaminarImagen();
            RutaImagen = ServicioImgs.SubirImagenAAzure(RutaImagen);
        }
    }
}
