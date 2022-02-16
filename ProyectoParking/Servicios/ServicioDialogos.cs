using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoParking.servicios
{
    static class ServicioDialogos
    {
        public static string ArchivoSeleccionado { get; set; }

        public static string ExaminarImagen()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;";


            bool? resultado = openFileDialog.ShowDialog();

            if (resultado == true)
            {
                ArchivoSeleccionado = openFileDialog.FileName;
                ServicioMessageBox($"Imagen cargada correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                return ArchivoSeleccionado;
            }
            else
            {
                ServicioMessageBox($"Error al cargar la imagen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return "";
            }

        }

        public static void ServicioMessageBox(string mensaje, string titulo, MessageBoxButton boxButton, MessageBoxImage messageBoxImage)
        {
            MessageBox.Show(mensaje, titulo, boxButton, messageBoxImage);
        }

    }
}
