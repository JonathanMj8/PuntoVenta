using PuntoVenta.Model;
using PuntoVenta.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuntoVenta.ViewModel
{
    public class TbaalmmovMV : Baseviewmodel
    {
        #region VARIABLES
        public ObservableCollection<TBAALMMOV> Allmmmov { get; set; }
        #endregion

        #region CONSTRUCTOR
        public TbaalmmovMV(INavigation navigation)
        {
            Navigation = navigation;
            _ = AddTbaalmmovAsync();

        }
        #endregion

        #region METODOS
        //NAVEGACION DE PAGINAS
        public async Task NavigationPage3()
        {
            await Navigation.PushAsync(new TbaalmmovdetView());
        }
        public async Task AddTbaalmmovAsync()
        {
            Allmmmov = new ObservableCollection<TBAALMMOV>(await App.Database.GetAll());
        }
        public async Task AgregarCommand()
        {
            await Navigation.PushAsync(new TbaalmmovdetAgregar());
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
        #region COMMANDOS
        //COMANDO PARA EL BOTON DE NEXTPAGE
        public ICommand NavigationPage3Command => new Command(async () => await NavigationPage3());
        public ICommand NavigationAgregarCommand => new Command(async () => await AgregarCommand());

        #endregion

    }
}
