using PuntoVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PuntoVenta.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TbaalmmovdetView : ContentPage
    {
        public TbaalmmovdetView()
        {
            InitializeComponent();
            BindingContext = new Tbaalmmovdet(Navigation);

        }
        //private async void LoadTbaalmmovdet()
        //{
        //    var items = await App.Database.GetAllTbaalmmovdet();
        //    allmmovdet.ItemsSource = items;

        //}
    }
}