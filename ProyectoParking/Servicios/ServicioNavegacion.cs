using ProyectoParking.ClasesModelo;
using ProyectoParking.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.servicios
{
    // Servicio que nos permite abrir nuevas vistas
    internal class ServicioNavegacion
    {
        public ServicioNavegacion() { }

        internal static bool? AbrirFormularioCliente() => new FormularioClienteDialog().ShowDialog();

        internal static bool? AbrirFormularioCliente(Cliente x, bool edit) => new FormularioClienteDialog(x, edit).ShowDialog();

        internal static bool? AbrirFormularioVehiculos() => new FormularioVehiculoDialog().ShowDialog();
        internal static bool? AbrirFormularioVehiculos(Vehiculo x, bool edit) => new FormularioVehiculoDialog(x, edit).ShowDialog();
        internal static bool? AbrriFormularioEstacionamientos() => new VerEstacionamientos().ShowDialog();
    }
}
