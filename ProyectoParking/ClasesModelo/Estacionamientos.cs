using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.ClasesModelo
{
    class Estacionamientos: ObservableObject
    {
        //Propiedades

        private int id_estacionamientos;

        public int Id_estacionamientos
        {
            get { return id_estacionamientos; }
            set { SetProperty(ref id_estacionamientos, value); }
        }

        private int id_vehiculo;

        public int Id_vehiculo
        {
            get { return id_vehiculo; }
            set { SetProperty(ref id_vehiculo, value); }
        }

        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { SetProperty(ref matricula, value); }
        }

        private string entrada;

        public string Entrada
        {
            get { return entrada; }
            set { SetProperty(ref entrada, value); }
        }

        private string salida;

        public string Salida
        {
            get { return salida; }
            set { SetProperty(ref salida, value); }
        }

        private double importe;

        public double Importe
        {
            get { return importe; }
            set { SetProperty(ref value, importe); }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { SetProperty(ref value, tipo); }
        }

        //Constructores

        public Estacionamientos() { }

        public Estacionamientos(int id_estacionamientos, int id_vehiculo, string matricula, string entrada, string salida, double importe, string tipo)
        {
            this.Id_estacionamientos = id_estacionamientos;
            this.id_vehiculo = id_vehiculo;
            this.Matricula = matricula;
            this.Entrada = entrada;
            this.Salida = salida;
            this.Importe = importe;
            this.Tipo = tipo;
        }

    }
}
