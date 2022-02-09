using Microsoft.Toolkit.Mvvm.ComponentModel;
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
        private ObservableCollection<EstacionamientosVM> estacionamientos;

        public ObservableCollection<EstacionamientosVM> Estacionamientos
        {
            get { return estacionamientos; }
            set { SetProperty(ref estacionamientos, value); }
        }

        public EstacionamientosVM()
        {

        }
    }
}
