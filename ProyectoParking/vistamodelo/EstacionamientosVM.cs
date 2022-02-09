using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.ClasesModelo;
using ProyectoParking.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.vistamodelo
{
    class EstacionamientosVM : ObservableObject
    {
        private ObservableCollection<Estacionamiento> estacionamientos;

        public ObservableCollection<Estacionamiento> Estacionamientos
        {
            get { return estacionamientos; }
            set { SetProperty(ref estacionamientos, value); }
        }

        public EstacionamientosVM()
        {
            Estacionamientos = ServicioDatabase.GetEstacionamientos();
        }
    }
}
