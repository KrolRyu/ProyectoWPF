﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
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
        private Estacionamientos estacionamiento;

        public  Estacionamientos Estacionamiento
        {
            get { return estacionamiento; }
            set { SetProperty(ref estacionamiento, value); }
        }

        //Constructor
        public VerEstacionamientosVM(Estacionamientos estacionamientos) 
        {
            this.Estacionamiento = estacionamientos;
            Estacionamiento.Importe = CalcularImporte();
        }

        //Metodos
        public void FinalizarEstacionamiento()
        {
            ServicioDatabase.EliminarEstacionamiento(Estacionamiento);
            
        }

        public double CalcularImporte()
        {
            //probar cuando ruben acabe y se pueda conectar
            //Creo que es mejor pasar este metodo a la clase de Estacionamiento
            double precioXMin = 1;
            DateTime fecharegistro = DateTime.Parse(Estacionamiento.Entrada);
            var tiempo = (DateTime.Now - fecharegistro).TotalMinutes;
            return double.Parse(tiempo.ToString()) * precioXMin;

        }

    }
}
