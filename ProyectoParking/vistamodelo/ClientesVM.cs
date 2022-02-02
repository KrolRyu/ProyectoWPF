using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.ClasesModelo;
using ProyectoParking.servicios;
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
            ClienteSel = new Cliente();
        }

        public void AñadirCliente()
        {
            ServicioNavegacion.AbrirFormularioCliente();
        }

        public void EditarCliente()
        {
            //ServicioDatabase.EditarCliente(ClienteSel);
        }

        public void EliminarCliente()
        {
            ServicioDatabase.EliminarCliente(ClienteSel);
        }
        
        public void RecargarDataGrid()
        {
            Clientes = ServicioDatabase.GetClientes();
        }
    }
}
