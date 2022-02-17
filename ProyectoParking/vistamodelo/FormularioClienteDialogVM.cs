using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoParking.ClasesModelo;
using ProyectoParking.servicios;
using ProyectoParking.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoParking.vistamodelo
{
    class FormularioClienteDialogVM : ObservableObject
    {
        private bool edit;

        public bool Edit
        {
            get { return edit; }
            set { SetProperty(ref edit, value); }
        }

        private string rutaImagen;

        public string RutaImagen
        {
            get { return rutaImagen; }
            set { SetProperty(ref rutaImagen, value); }
        }

        private Cliente clienteSel;

        public Cliente ClienteSel
        {
            get { return clienteSel; }
            set { SetProperty(ref clienteSel, value); }
        }

        public FormularioClienteDialogVM()
        {
            ClienteSel = new Cliente();
        }

        public void ExaminarImagen()
        {
            if (ClienteSel.Foto != null)
            {
                RutaImagen = ServicioDialogos.ExaminarImagen();
                ClienteSel.Foto = ServicioImgs.SubirImagenAAzure(RutaImagen);
            }
        }

        public void InsertarCliente()
        {
            if (Edit)
            {
                ServicioDatabase.EditarCliente(ClienteSel);
            }
            else
            {
                if (ClienteSel.Nombre != null && ClienteSel.Documento != null && ClienteSel.Foto != null && ClienteSel.Telefono != null)
                {
                    ServicioDatabase.InsertarCliente(new Cliente(ClienteSel.Nombre, ClienteSel.Documento, ClienteSel.Foto, ClienteSel.Telefono));
                }
                else
                {
                    ServicioDialogos.ServicioMessageBox("Completa todos los campos para poder crear un cliente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }
    }
}
