﻿using PuntoVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace PuntoVenta.Views
{
    [Preserve(AllMembers = true)]

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TbaalmmovPage : ContentPage
    {
        public TbaalmmovPage()
        {
            InitializeComponent();
            BindingContext = new TbaalmmovMV(Navigation);
            
        }

        private void BusquedaArticuloText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TapGestureRecognizer_MostrarFiltrosAvanzados(object sender, EventArgs e)
        {

        }
    }
}