using PuntoVenta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.ViewModel
{
    public class CarritoViewModel : Baseviewmodel
    {
        internal Action<object> mostrarAreaDatosGenerales;
        #region variables
        public ObservableCollection<TBAALMMOV> Allmmmov { get; set; }
         
        public string CodigoClienteEditar { get; internal set; }
        public bool EditarMovimiento { get; internal set; }
        public bool BuscadorMovimientosVisible { get; internal set; }
        public bool EdicionMovimientosVisible { get; internal set; }
        public int IDALMMOV { get; internal set; }
        public bool BotonesGuardarVisibles { get; internal set; }
        public string FOLIO { get; internal set; }
        public bool BuscadorMovimientoVisible { get; internal set; }
        public bool BusquedaMovimientosSinResultados { get; internal set; }
        public bool ListaMovimientosBusquedaVisible { get; internal set; }
        public bool NuevoMovimiento { get; internal set; }
        public bool DetalleOfertaVisible { get; internal set; }
        public bool BuscadorArticulosVisible { get; internal set; }
        public string TituloVentanaEdicionCliente { get; internal set; }
        #endregion

        #region Contructor
        public CarritoViewModel()
        {
            _ = AddTbaalmmovAsync();
        }
        #endregion
        #region METODOS
        public async Task AddTbaalmmovAsync()
        {
            Allmmmov = new ObservableCollection<TBAALMMOV>(await App.Database.GetAll());
        }

        public void RemoverMovimiento(int iDALMMOV)
        {
         }

        public void AgregarMovimiento()
        {
         }

        public void CerrarEdicionMovimiento()
        {
         }

        public void CambiarCantidadMovimiento(int iDALMMOV, bool v)
        {
         }

        public void EditarMovimientos(TBAALMMOV data)
        {
         }

        public void AfectarMovimiento()
        {
         }

        public void GuardarMovimiento()
        {
         }

        public void MostrarOfertasProducto()
        {
         }

        internal void MostrarMovimientoEditar()
        {
            throw new NotImplementedException();
        }



        #endregion

    }
}
