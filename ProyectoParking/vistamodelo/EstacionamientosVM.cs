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
        public EstacionamientosVM()
        {
            private ObservableCollection<Estacionamiento> myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public EstacionamientosVM()
            {

            }

        }
    }
}
