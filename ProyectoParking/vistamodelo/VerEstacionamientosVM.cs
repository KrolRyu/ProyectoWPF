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
            double descuento = 20;
            bool abonado = false;
            if (Estacionamiento.Id_vehiculo != null)
            {
                abonado = true;
            }
            double precioXMin = 0.01;
            DateTime fecharegistro = DateTime.Parse(Estacionamiento.Entrada);
            var tiempo = (DateTime.Now - fecharegistro).TotalMinutes;
            if (abonado)
            {
                double precioSinDescuento = double.Parse(tiempo.ToString()) * precioXMin;
                return Math.Round(precioSinDescuento - (precioSinDescuento * (descuento / 100)), 2);
            }
            else
            {
                return Math.Round(double.Parse(tiempo.ToString()) * precioXMin, 2);
            }
        }

    }
}
