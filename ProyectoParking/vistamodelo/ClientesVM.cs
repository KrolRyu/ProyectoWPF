﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
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
    class ClientesVM : ObservableObject
    {
        private ObservableCollection<Cliente> clientes;

        public ObservableCollection<Cliente> Clientes
        {
            get { return clientes; }
            set { SetProperty(ref clientes, value); }
        }

        private Cliente clienteSel;

        public Cliente ClienteSel
        {
            get { return clienteSel; }
            set { SetProperty(ref clienteSel, value); }
        }

        public ClientesVM()
        {
            Clientes = ServicioDatabase.GetClientes();
        }

        public void AñadirCliente()
        {
            //ServicioDatabase.InsertarCliente(/* new Cliente con los datos de la ventana de añadir */);
        }

        public void EditarCliente()
        {
            ServicioDatabase.EditarCliente(ClienteSel);
        }

        public void EliminarCliente()
        {
            ServicioDatabase.EliminarCliente(ClienteSel);
        }
    }
}
