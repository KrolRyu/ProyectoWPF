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

        private Vehiculo vehiculoSel;

        public Vehiculo VehiculoSel
        {
            get { return vehiculoSel; }
            set { SetProperty(ref vehiculoSel, value); }
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
            this.vehiculoSel = new Vehiculo();
            nuevo = true;
        }

        //Constructor de editar
        public FormularioVehiculoDialogVM(Vehiculo vehiculo)
        {
            this.vehiculoSel = vehiculo;
            nuevo = false;

        }

        //Metodos

        public void SubirImagenAzure()
        {

            FotoVehiculo = ServicioDialogos.ExaminarImagen();
            FotoVehiculo = ServicioImgs.SubirImagenAAzure(FotoVehiculo);

            //El servicio de subir imagenes a azure devuelve cadena vacia si da una excepcion
            if(fotoVehiculo == "")
            {
                ServicioDialogos.ServicioMessageBox("Se ha producido un error subiendo la imagen", "ERROR", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }

        public void GuardarVehiculo()
        {
            if (nuevo)
            {
                ServicioDatabase.InsertarVehiculo(new Vehiculo(VehiculoSel.IdVehiculo, VehiculoSel.IdCliente, FotoVehiculo, VehiculoSel.Modelo, VehiculoSel.IdMarca));
            }
            else
            {
                ServicioDatabase.EditarVehiculo(vehiculoSel);
            }
        }

    }
}
