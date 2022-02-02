using ProyectoParking.servicios;
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
    /// Lógica de interacción para FormularioClienteDialog.xaml
    /// </summary>
    public partial class FormularioClienteDialog : Window
    {
        private FormularioClienteDialogVM vm = new FormularioClienteDialogVM();
        public FormularioClienteDialog()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void ButtonAdv_Click(object sender, RoutedEventArgs e)
        {
            vm.ExaminarImagen();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            vm.InsertarCliente();
        }
    }
}
