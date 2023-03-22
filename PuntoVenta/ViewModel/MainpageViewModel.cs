using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PuntoVenta.Views;
using System.Linq;

namespace PuntoVenta.ViewModel
{
    public class MainpageViewModel : Baseviewmodel
    {

        #region VARIABLE
        //public String Hola { get; set; }
        #endregion

        #region CONSTRUCTOR
        public MainpageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region PROCESO
        public async Task NavigationPage2()
        {
            await Navigation.PushAsync(new TbaalmmovPage());
        }
        #endregion

        #region COMANDOS

        public ICommand NavigationPage2Command => new Command(async () => await NavigationPage2());

        #endregion
    }
}
