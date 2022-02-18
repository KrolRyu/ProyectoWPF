using ProyectoParking.Servicios;
using ProyectoParking.vistas;
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

namespace ProyectoParking
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowVM vm = new MainWindowVM();
        public MainWindow()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Properties.Settings.Default.LicenciaSyncfusion);
            InitializeComponent();
            ServicioDatabase.ConnectDatabase();
            this.contentControl.Content = new Inicio();
            DataContext = vm;
        }

        private void NavigationDrawer_ItemClicked(object sender, Syncfusion.UI.Xaml.NavigationDrawer.NavigationItemClickedEventArgs e)
        {                    
            switch (e.Item.Tag)
            {
                case "Clientes":
                    contentControl.Content = new Clientes();
                    break;
                case "Vehiculos":
                    contentControl.Content = new Vehiculos();
                    break;
                case "Estacionamientos":
                    contentControl.Content = new Estacionamientos();
                    break;
                case "Manual":
                    // SE INVOCA EL MANUAL (nueva ventana)
                    break;
                default:
                    break;
            }
        }
    }
}
