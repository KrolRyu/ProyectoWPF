using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.ClasesModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.vistamodelo
{
    class VerEstacionamientosVM: ObservableObject
    {
        //Propiedades
        private Estacionamiento estacionamientos;

        public  Estacionamiento Estacionamientos
        {
            get { return estacionamientos; }
            set { SetProperty(ref estacionamientos, value); }
        }

        //Constructor
        public VerEstacionamientosVM() { }

        //Metodos
        public void finalizarEstacionamiento()
        {
            //TODO hacer que al clickar este boton se borre el estacionamiento de la base de datos
            
        }

    }
}
