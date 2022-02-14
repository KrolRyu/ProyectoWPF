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
    class VerEstacionamientosVM: ObservableObject
    {
        //Propiedades
        private Estacionamiento estacionamiento;

        public  Estacionamiento Estacionamiento
        {
            get { return estacionamiento; }
            set { SetProperty(ref estacionamiento, value); }
        }

        //Constructor
        public VerEstacionamientosVM(Estacionamiento estacionamiento) 
        {
            this.Estacionamiento = estacionamiento;
            Estacionamiento.Importe = CalcularImporte();
        }

        public VerEstacionamientosVM ()
        {

        }

        //Metodos
        public void FinalizarEstacionamiento()
        {
            //TODO esto no tiene que eliminar de la base de datos, simplemente tiene que poner alguna propiedad de estacionado a false
            ServicioDatabase.EliminarEstacionamiento(Estacionamiento);
            
        }

        public double CalcularImporte()
        {
            //probar cuando Ruben acabe y se pueda conectar
            double precioXMin = 1;
            DateTime fecharegistro = DateTime.Parse(Estacionamiento.Entrada);
            var tiempo = (DateTime.Now - fecharegistro).TotalMinutes;
            return double.Parse(tiempo.ToString()) * precioXMin;
        }

    }
}
