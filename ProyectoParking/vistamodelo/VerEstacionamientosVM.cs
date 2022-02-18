using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using ProyectoParking.ClasesModelo;
using ProyectoParking.mensajeria;
using ProyectoParking.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParking.vistamodelo
{
    class VerEstacionamientosVM : ObservableRecipient
    {
        //Propiedades
        private Estacionamiento estacionamiento;

        public Estacionamiento Estacionamiento
        {
            get { return estacionamiento; }
            set { SetProperty(ref estacionamiento, value); }
        }

        public VerEstacionamientosVM()
        {
            Estacionamiento = WeakReferenceMessenger.Default.Send<EstacionamientoSelMessage>();
            Estacionamiento.Importe = CalcularImporte();
        }

        //Metodos
        public void FinalizarEstacionamiento()
        {
            Estacionamiento.Salida = DateTime.Now.ToString();
            ServicioDatabase.EditarEstacionamiento(Estacionamiento);
        }

        public double CalcularImporte()
        {
            //Si tiene un vehiculo asociado significa que es abonado
            int descuento = 20;
            bool abonado = false;
            if (Estacionamiento.Id_vehiculo != null)
            {
                abonado = true;
            }
            double precioXMin = 1;
            DateTime fecharegistro = DateTime.Parse(Estacionamiento.Entrada);
            var tiempo = (DateTime.Now - fecharegistro).TotalMinutes;
            if (abonado)
            {
                return (double.Parse(tiempo.ToString()) * precioXMin) * (descuento / 100);
            }
            else
            {
                return double.Parse(tiempo.ToString()) * precioXMin;
            }
        }

    }
}
