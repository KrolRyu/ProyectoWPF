using ProyectoParking.vistamodelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoParking.vistas
{
    /// <summary>
    /// Lógica de interacción para VerEstacionamientos.xaml
    /// </summary>
    public partial class VerEstacionamientos : Window
    {
        VerEstacionamientosVM vm = new VerEstacionamientosVM();
        public VerEstacionamientos()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Finalizar_Click(object sender, RoutedEventArgs e)
        {
            vm.FinalizarEstacionamiento();
            DialogResult = true;
        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            // Cerrará el dialogo
            DialogResult = true;
        }
    }
}
