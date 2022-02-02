using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.ClasesModelo;
using ProyectoParking.servicios;
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

        private bool nuevo;

        public bool Nuevo
        {
            get { return nuevo; }
            set { SetProperty(ref nuevo, value); }
        }


        //Contructores
        //Contructor de crear
        public FormularioVehiculoDialogVM()
        {
            this.vehiculoActual = new Vehiculo();
            nuevo = true;
        }

        //Constructor de editar
        public FormularioVehiculoDialogVM(Vehiculo vehiculo)
        {
            this.vehiculoActual = vehiculo;
            nuevo = false;

        }

        //Metodos

        public void SacarMatriculaYTipo()
        {
            FotoVehiculo = ServicioDialogos.ExaminarImagen();
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
                ServicioDialogos.ServicioMessageBox("Se ha producido un error subiendo la imagen", "ERROR", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }

        public void GuardarVehiculo()
        {
            if (nuevo)
            {
                ServicioDatabase.InsertarVehiculo(vehiculoActual);
            }
            else
            {
                ServicioDatabase.EditarVehiculo(VehiculoActual);
            }
        }

    }
}
