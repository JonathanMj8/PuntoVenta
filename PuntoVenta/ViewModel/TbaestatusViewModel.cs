using PuntoVenta.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace PuntoVenta.ViewModel
{
    public class TbaestatusViewModel : Baseviewmodel
    {
        #region VARIABLES
        public ObservableCollection<TBAESTATUS> Allestatus { get; set; }
        #endregion
        #region CONSTRUCTOR
        public TbaestatusViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _ = AddTbaestatus();
        }
        #endregion

        #region METODOS
        //NAVEGACION DE PAGINAS
        public void NavigationPage3()
        {
            //await Navigation.PushAsync(new TbaalmmovdetView());
        }
        public async Task AddTbaestatus()
        {
            Allestatus = new ObservableCollection<TBAESTATUS>(await App.Database.GetAllTbaestatus());
        }

        public static async Task<int> Guardarestatus()
        {
            int result = 0;
            TBAESTATUS newestattus = new TBAESTATUS()
            {
                    DESCRIPCION = "GUARDADO",
                    COLOR = "#F9E79F",
                    CODIGO = "LMD612",
                    IDTIPOESTATUS = 1,
                    PERMITEFACTURAR = true,
                    ESTATUSCOMENTARIO = "C",
                    COLORFUENTEESTATUS = "VERDE",
                    IDESTATUSRELACION = 1
            };
            result = await App.Database.SaveTbaestatus(newestattus);
            return result;
        }
    
        public static async Task<List<TBAESTATUS>> GetAllEstatus()
        {
            List<TBAESTATUS> estatusList = null;
            estatusList = await App.Database.GetAllTbaestatus();
            return estatusList;
        }

        public static async Task<TBAESTATUS> GetAllEstatusId(int id = 8)
        {
            TBAESTATUS idestatus = null;
            idestatus = await App.Database.GetTbaestatusId(id);
            return idestatus;
        }
        //Eliminar por ID
        public static async Task<int> DeleteEstatusId(int id = 10)
        {
            int result = 0;
            var deleteestatusid = await App.Database.GetTbaestatusId(id);
            if (deleteestatusid != null)
            {
                //Delete Person
                await App.Database.DeleteTbaestatus(deleteestatusid);
            }
            return result;
        }
        #endregion

    }
}
