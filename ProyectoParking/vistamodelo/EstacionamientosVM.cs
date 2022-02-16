using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using ProyectoParking.ClasesModelo;
using ProyectoParking.mensajeria;
using ProyectoParking.servicios;
using ProyectoParking.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParking.vistamodelo
{
    class EstacionamientosVM : ObservableObject
    {
        private ObservableCollection<Estacionamiento> estacionamientos;

        public ObservableCollection<Estacionamiento> Estacionamientos
        {
            get { return estacionamientos; }
            set { SetProperty(ref estacionamientos, value); }
        }

        private Estacionamiento estacionamientoSel;

        public Estacionamiento EstacionamientoSel
        {
            get { return estacionamientoSel; }
            set { SetProperty(ref estacionamientoSel, value); }
        }

        public RelayCommand VerDatosCommand { get; }
        public EstacionamientosVM()
        {
            Estacionamientos = new ObservableCollection<Estacionamiento>();
            ObservableCollection<Estacionamiento> listaEstacionamientos = ServicioDatabase.GetEstacionamientos();
            foreach(Estacionamiento estacionamiento in listaEstacionamientos)
            {
                if(estacionamiento.Salida == "")
                {
                    Estacionamientos.Add(estacionamiento);
                }
            }

            EstacionamientoSel = null;
            VerDatosCommand = new RelayCommand(VerFormularioEstacionamiento);

            WeakReferenceMessenger.Default.Register<EstacionamientosVM, EstacionamientoSelMessage>
                (this, (r, m) =>
                {
                    m.Reply(EstacionamientoSel);
                });
        }

        private void VerFormularioEstacionamiento()
        {
            ServicioNavegacion.AbrriFormularioEstacionamientos();
        }
    }
}
