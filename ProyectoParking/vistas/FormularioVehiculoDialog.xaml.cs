using ProyectoParking.ClasesModelo;
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
    /// Lógica de interacción para FormularioVehiculoDialog.xaml
    /// </summary>
    public partial class FormularioVehiculoDialog : Window
    {
        FormularioVehiculoDialogVM vm = new FormularioVehiculoDialogVM();

        public FormularioVehiculoDialog()
        {
            DataContext = vm;
            InitializeComponent();
        }

        /*public FormularioVehiculoDialog(Vehiculo vehiculoSel, bool nuevo)
        {
            DataContext = vm;
            InitializeComponent();
            vm.VehiculoSel = vehiculoSel;
            vm.Nuevo = nuevo;
        } TODO: Arreglar error */

        private void ButtonAdv_Click(object sender, RoutedEventArgs e)
        {
            vm.SacarMatriculaYTipo();
        }

        private void ButtonAdv_Click_1(object sender, RoutedEventArgs e)
        {
            vm.GuardarVehiculo();
        }
    }
}
