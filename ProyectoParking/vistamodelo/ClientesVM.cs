using Microsoft.Data.Sqlite;
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
using System.Windows;

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
            ServicioNavegacion.AbrirFormularioCliente();
            RecargarDataGrid();
        }

        public void EditarCliente()
        {
            if (ClienteSel != null)
            {
                ServicioNavegacion.AbrirFormularioCliente(ClienteSel, true);

            }
            else
            {
                ServicioDialogos.ServicioMessageBox("Selecciona un cliente para poder editarlo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            RecargarDataGrid();
        }

        public void EliminarCliente()
        {
            // Caputramos excepción para mostrar diálogo si el cliente tiene un vehículo asociado
            try
            {
                ServicioDatabase.EliminarCliente(ClienteSel);
                RecargarDataGrid();
            }
            catch (SqliteException)
            {
                ServicioDialogos.ServicioMessageBox("Borra los vehículos asociados al cliente primero", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void RecargarDataGrid()
        {
            Clientes = ServicioDatabase.GetClientes();
        }
    }
}
