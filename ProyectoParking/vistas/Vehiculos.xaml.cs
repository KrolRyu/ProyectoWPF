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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoParking.vistas
{
    /// <summary>
    /// Lógica de interacción para Vehiculos.xaml
    /// </summary>
    public partial class Vehiculos : UserControl
    {
        private VehiculosVM vm = new VehiculosVM();
        public Vehiculos()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            vm.AñadirVehiculo();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            vm.EditarVehiculo();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            vm.EliminarVehiculo();
        }
    }
}
