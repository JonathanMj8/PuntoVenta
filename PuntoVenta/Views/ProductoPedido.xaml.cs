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
    public partial class ProductoPedido : ContentPage
    {
        public ProductoPedido()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _ = Volver();
        }

        public async Task Volver()
        {
            await Navigation.PushAsync(new Carrito());
        }
    }
}
