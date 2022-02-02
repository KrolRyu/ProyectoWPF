using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.ClasesModelo;
using ProyectoParking.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.vistamodelo
{
    class FormularioVehiculoDialogVM: ObservableObject
    {
        //Propiedades

        private Vehiculo vehiculoActual;

        public Vehiculo VehiculoActual
        {
            get { return vehiculoActual; }
            set { SetProperty(ref vehiculoActual, value); }
        }

        private string fotoVehiculo;

        public string FotoVehiculo
        {
            get { return fotoVehiculo; }
            set { SetProperty(ref fotoVehiculo, value); }
        }

        //Contructor
        public FormularioVehiculoDialogVM()
        {
            this.vehiculoActual = new Vehiculo();
        }

        //Metodos

        public void SacarMatriculaYTipo()
        {
            //Cuando el servicio de subir imagen en fichero este hecho, recoger la imagen en la variable
            FotoVehiculo = ServicioImgs.SubirImagenAAzure(FotoVehiculo);
            if(FotoVehiculo != "")
            {
                //TODO sacar la matricula y el tipo
                string matricula = "";
                string tipo = "";
                VehiculoActual.Tipo = tipo;
                VehiculoActual.Matricula = matricula;
            }
            else
            {
                //TODO usar el servicio de mensajes para que diga que ha habido un error
            }
        }

    }
}
