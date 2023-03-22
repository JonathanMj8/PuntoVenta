﻿using PuntoVenta.Model;
using PuntoVenta.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuntoVenta.ViewModel
{
    public class TbaalmmovViewModel : Baseviewmodel
    {
        #region VARIABLES
        public ObservableCollection<TBAALMMOV> Allmmmov { get; set; }

        private bool _BtnBackMenuVisible;
        public bool BtnBackMenuVisible
        {
            get { return _BtnBackMenuVisible; }
            set
            {
                _BtnBackMenuVisible = value;
                OnPropertyChanged(nameof(BtnBackMenuVisible));
            }
        }
        private bool _MostrarFiltrosAvanzados;
        public bool MostrarFiltrosAvanzados
        {
            get { return _MostrarFiltrosAvanzados; }
            set
            {
                _MostrarFiltrosAvanzados = value;
                OnPropertyChanged(nameof(MostrarFiltrosAvanzados));
            }
        }
        #endregion
        #region COMMANDOS

        //COMANDO PARA EL BOTON DE NEXTPAGE
        public ICommand NavigationPage3Command => new Command(async () => await NavigationPage3());
        public ICommand NavigationAgregarCommand => new Command(async () => await AgregarCommand());
        public ICommand NuevoPedidoCommand => new Command(async () => await NuevoPedidoCommandAsync());

        public ICommand _ocultarMenu;
        public ICommand TapGestureRecognizer_OcultarMenu
        {
            get { return _ocultarMenu; }
        }

        public ICommand _mostrarfiltros;
        public ICommand TapGestureRecognizer_MostrarFiltrosAvanzados
        {
            get { return _mostrarfiltros; }
        }

        public ICommand _ocultarfiltros;
        public ICommand TapGestureRecognizer_CerrarFiltrosAvanzados
        {
            get { return _ocultarfiltros; }
        }
        #endregion

        #region CONSTRUCTOR
        public TbaalmmovViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _ = AddTbaalmmovAsync();
            _mostrarfiltros = new Command(mostrarFiltrosAvanzados);
            _ocultarfiltros = new Command(CerrarFiltrosAvanzados);
            _ocultarMenu = new Command(OcultarMenu);
        }
        #endregion

        #region METODOS
        public async Task AddTbaalmmovAsync()
        {
            Allmmmov = new ObservableCollection<TBAALMMOV>(await App.Database.GetAll());
        }
        public async Task NavigationPage3()
        {
            await Navigation.PushAsync(new TbaalmmovdetView());
        }
        public async Task AgregarCommand()
        {
            await Navigation.PushAsync(new TbaalmmovdetAgregar());
        }
        public async Task NuevoPedidoCommandAsync()
        {
            await Navigation.PushAsync(new ProductoPedido());
        }
        void OcultarMenu(object s)
        {
            BtnBackMenuVisible = true;
        }
        void mostrarFiltrosAvanzados(object s)
        {
            MostrarFiltrosAvanzados = true;
        }
        void CerrarFiltrosAvanzados(object s)
        {
            MostrarFiltrosAvanzados = false;
        }
        #endregion
           
        #region GUARDAR
        public static async Task<int> GuardarAllmmov()
        {
            int result = 0;
            TBAALMMOV newallmmov = new TBAALMMOV()
                {
                    IDTIPOMOV = 1,
                    FECHA = DateTime.Now,
                    FOLIO = "MOV-04",
                    OBSERVACIONES = "Ninguna",
                    SUBTOTAL = (decimal)20.1,
                    IVA = (decimal)12.1,
                    TOTAL = (decimal)290.1,
                    AFECTO = 1,
                    CANCELADO = 1,
                    FECHACANCELADO = DateTime.Now,
                    IDESTATUS = 7,
                    IDUSUARIO = 1,
                    IDSUCURSALESDESTINO = 2,
                    FACTURADO = 1,
                    IDCAUSA = 1,
                    IDMOTIVOMOV = 1,
                    IdAplicacion = Guid.NewGuid(),
                    IDSUCURSALORIGEN = 2,
                    IDALMMOVRELACIONADO = 2,
                    CONCILIADO = false,
                    IDAPLICACIONRELACIONADO = Guid.NewGuid(),
                    IDSUCURSAL = 2,
                    USUARIOIDAPP = Guid.NewGuid(),
                    IDFACTURO = 1,
                    IDFACTUROIDAPP = Guid.NewGuid(),
                    IESPS = (decimal)1.3
                };
            result = await App.Database.SaveTbaalmmov(newallmmov);
            return result;
        }
        #endregion

        #region MOSTRAR
        public static async Task<List<TBAALMMOV>> GetTbaalmmovAll()
        {
            List<TBAALMMOV> tbaalmmovlist = null;
            tbaalmmovlist = await App.Database.GetAllTbaalmmov();
            return tbaalmmovlist;
        }

        public static async Task<TBAALMMOV> GetTbaalmmovId(int id)
        {
            TBAALMMOV tbaalmmovId = null;
            tbaalmmovId = await App.Database.GetTbaalmmovId(id);
            return tbaalmmovId;
        }
        #endregion

        #region ELIMINAR
        public static async Task<int> DeleteTbaalmmovId(int id = 9)
        {
            int result = 0;
            var aalmmovDeleteId = await App.Database.GetTbaalmmovId(id);
            if (aalmmovDeleteId != null)
            {
                await App.Database.DeleteTbaalmmov(aalmmovDeleteId);
            }
            return result;
        }
        #endregion

       

    }
}
