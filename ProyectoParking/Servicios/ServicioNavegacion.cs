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

        internal static bool? AbrirFormularioVehiculos() => new FormularioVehiculoDialog().ShowDialog();
    }
}
