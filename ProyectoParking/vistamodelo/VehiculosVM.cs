using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.ClasesModelo;
using ProyectoParking.servicios;
using ProyectoParking.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoParking.vistamodelo
{
    class VehiculosVM : ObservableObject
    {
        private ObservableCollection<Vehiculo> vehiculos;

        public ObservableCollection<Vehiculo> Vehiculos
        {
            get { return vehiculos; }
            set { SetProperty(ref vehiculos, value); }
        }

        private Vehiculo vehiculoSel;

        public Vehiculo VehiculoSel
        {
            get { return vehiculoSel; }
            set { SetProperty(ref vehiculoSel, value); }
        }

        public VehiculosVM()
        {
            Vehiculos = ServicioDatabase.GetVehiculos();
        }

        public void AñadirVehiculo()
        {
            ServicioNavegacion.AbrirFormularioVehiculos();
        }

        public void EditarVehiculo()
        {
            if (VehiculoSel != null)
            {
                ServicioNavegacion.AbrirFormularioVehiculos(VehiculoSel, true);

            }
            else
            {
                ServicioDialogos.ServicioMessageBox("Selecciona un vehículo para poder editarlo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void EliminarVehiculo()
        {
            ServicioDatabase.EliminarVehiculo(VehiculoSel);
        }
    }
}
