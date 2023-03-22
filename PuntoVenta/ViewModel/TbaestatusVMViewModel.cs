using PuntoVenta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PuntoVenta.ViewModel
{
    public class TbaestatusVMViewModel : Baseviewmodel
    {
        #region VARIABLES
        public ObservableCollection<TBAESTATUS> Allestatus { get; set; }
        #endregion
        #region CONSTRUCTOR
        public TbaestatusVMViewModel(INavigation navigation)
        {
            Navigation = navigation;
            AddTbaestatus();
        }
        //NAVEGACION DE PAGINAS
        public void NavigationPage3()
        {
            //await Navigation.PushAsync(new TbaalmmovdetView());
        }
        #endregion
        public void AddTbaestatus()
        {

            Allestatus = new ObservableCollection<TBAESTATUS>();
            Allestatus.Add(
                new TBAESTATUS
                {
                    IDESTATUS = 1,
                    DESCRIPCION = "CANCELADO",
                    COLOR = "ROJO",
                    CODIGO = "LMD612",
                    IDTIPOESTATUS = 1,
                    PERMITEFACTURAR = true,
                    ESTATUSCOMENTARIO = "C",
                    COLORFUENTEESTATUS = "ROJO",
                    IDESTATUSRELACION = 3
                });
        }
        public static async Task<List<TBAESTATUS>> GetAllEstatus()
        {
            List<TBAESTATUS> estatusList = null;
            estatusList = await App.Database.GetAllTbaestatus();
            return estatusList;
        }

    }
}
