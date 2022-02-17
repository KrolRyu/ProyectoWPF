using ProyectoParking.ClasesModelo;
using ProyectoParking.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.servicios
{
    /// <summary>
    /// Servicio que nos permite movernos entre las diferentes vistas
    /// </summary>
    internal class ServicioNavegacion
    {
        protected ServicioNavegacion() { }

        /// <summary>
        /// Abre el formulario de cliente para crear un cliente nuevo
        /// </summary>
        /// <returns>
        /// Devuelve el resultado del dialogo
        /// </returns>
        internal static bool? AbrirFormularioCliente() => new FormularioClienteDialog().ShowDialog();


        /// <summary>
        /// Abre el formulario de cliente para editar un cliente
        /// </summary>
        /// <param name="x">
        /// El cliente a editar
        /// </param>
        /// <param name="edit">
        /// Booleano para saber si hay que editar el cliente o añadir uno
        /// </param>
        /// <returns>
        /// Devuelve el resultado del dalogo
        /// </returns>
        internal static bool? AbrirFormularioCliente(Cliente x, bool edit) => new FormularioClienteDialog(x, edit).ShowDialog();

        /// <summary>
        /// Abre el formulario de vehiculos para crear un vehiculo nuevo
        /// </summary>
        /// <returns>
        /// Devuelve el resultado del dalogo
        /// </returns>
        internal static bool? AbrirFormularioVehiculos() => new FormularioVehiculoDialog().ShowDialog();

        /// <summary>
        /// Abre el formulario de vehiculos para crear uno nuevo
        /// </summary>
        /// <param name="x">
        /// el vehiculo a editar
        /// </param>
        /// <param name="edit">
        /// Booleano para saber si hay que editar el vehiculo o no
        /// </param>
        /// <returns>
        /// Devuelve el resultado del dialgo
        /// </returns>
        internal static bool? AbrirFormularioVehiculos(Vehiculo x, bool edit) => new FormularioVehiculoDialog(x, edit).ShowDialog();

        /// <summary>
        /// Abre el formulario de estacionamientos
        /// </summary>
        /// <returns>
        /// Devuelve el resultado del dialogo
        /// </returns>
        internal static bool? AbrriFormularioEstacionamientos() => new VerEstacionamientos().ShowDialog();
    }
}
