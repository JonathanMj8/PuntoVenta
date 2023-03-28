using PuntoVenta.Model;
using PuntoVenta.ViewModel;
using Syncfusion.ListView.XForms;
using Syncfusion.XForms.ComboBox;
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
    public partial class Carrito : ContentPage
    {
        public bool ajustesClientes = false;

        public Carrito()
        {
            InitializeComponent();

            ListaCarrito.PropertyChanged += ListView_PropertyChanged;
            ListaCarrito.SwipeEnded += ListView_SwipeEnded;
            ListaCarrito.Swiping += MovimientosList_Swiping;
            ListaCarrito.SwipeStarted += ListView_SwipeStarted;

            NavigationPage.SetBackButtonTitle(this, "");

            TituloPedidos.Text = "Agrega Productos al Pedido";

            Shell.SetBackButtonBehavior(this, new BackButtonBehavior
            {
                Command = new Command(async () =>
                {
                    // true or false to disable or enable the action
                    if (((CarritoViewModel)this.BindingContext).BuscadorMovimientosVisible == true)
                    {
                        ((CarritoViewModel)this.BindingContext).BuscadorMovimientosVisible = false;
                        ((CarritoViewModel)this.BindingContext).EdicionMovimientosVisible = false;
                        ((CarritoViewModel)this.BindingContext).BotonesGuardarVisibles = true;

                        if (((CarritoViewModel)this.BindingContext).IDALMMOV > 0)
                        {
                            TituloPedidos.Text = "Edita Movimiento " + ((CarritoViewModel)this.BindingContext).FOLIO;
                        }
                        else
                        {
                            TituloPedidos.Text = "Nuevo Movimiento";
                        }
                    }
                    else
                    {
                        PreguntarSalir();
                    }
                })
            });
            ((CarritoViewModel)this.BindingContext).mostrarAreaDatosGenerales = ((obj) =>
            {
                MostrarAreaDatosGenerales();
            });

        }
        public async void PreguntarSalir()
        {
            bool salir = await DisplayAlert("¿Salir sin Guardar?", "El Movimientos no será guardado", "Salir", "Permanecer");
            {
                if (salir == true)
                {
                    await Shell.Current.Navigation.PopAsync();
                }
            }
        }

        private void ListView_SwipeStarted(object sender, Syncfusion.ListView.XForms.SwipeStartedEventArgs e)
        {

            if (((CarritoViewModel)this.BindingContext).EditarMovimiento == false)
                e.Cancel = true;
        }

        private void MovimientosList_Swiping(object sender, SwipingEventArgs e)
        {
            /*
            if (e.SwipeOffSet >= 150)
            {
                ((CarritoViewModel)this.BindingContext).EstablecerItemSwipeColor(true);
            }
            else
            {
                ((CarritoViewModel)this.BindingContext).EstablecerItemSwipeColor(false);
            }*/
        }

        private void ListView_SwipeEnded(object sender, Syncfusion.ListView.XForms.SwipeEndedEventArgs e)
        {
            if (e.SwipeDirection == Syncfusion.ListView.XForms.SwipeDirection.Left && e.SwipeOffset >= 150)
            {
                TBAALMMOV producto = e.ItemData as TBAALMMOV;
                int IDALMMOV = producto.IDALMMOV;
                ((CarritoViewModel)this.BindingContext).RemoverMovimiento(IDALMMOV);
                e.SwipeOffset = 0;
            }
        }


        private void ListView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Width" && ListaCarrito.Orientation == Orientation.Vertical && ListaCarrito.SwipeOffset != ListaCarrito.Width)
                ListaCarrito.SwipeOffset = ListaCarrito.Width;
            else if (e.PropertyName == "Height" && ListaCarrito.Orientation == Orientation.Horizontal && ListaCarrito.SwipeOffset != ListaCarrito.Height)
                ListaCarrito.SwipeOffset = ListaCarrito.Height;
        }

        public void MostrarAreaDatosGenerales()
        {
            // Height (in pixels)
            var height = Application.Current.MainPage.Height;

            //Se pusieron aqui estas propiedades para el combobox por que en xaml no permite cargar el valor inicial
            if (Device.RuntimePlatform == Device.iOS)
            {
                comboBox.IsEditableMode = true;
                comboBox.AllowFiltering = true;
                comboBox.SuggestionMode = SuggestionMode.Contains;
            }

            expander_datos_movimiento.IsExpanded = true;
            ScrollDatosGenerales.HeightRequest = height - 160;
        }

       
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called
        }

        private void expander_datos_movimiento_Expanded(object sender, Syncfusion.XForms.Expander.ExpandedAndCollapsedEventArgs e)
        {
            TituloDatosGenerales.Text = "Edita Datos Generales del Movimiento";

            if (Device.RuntimePlatform == Device.iOS)
            {
                comboBox.IsEditableMode = true;
                comboBox.AllowFiltering = true;
                comboBox.SuggestionMode = SuggestionMode.Contains;

            }

            // Height (in pixels)
            var height = Application.Current.MainPage.Height;
            ScrollDatosGenerales.HeightRequest = height - 160;
        }

        private void expander_datos_movimiento_Collapsed(object sender, Syncfusion.XForms.Expander.ExpandedAndCollapsedEventArgs e)
        {
            TituloDatosGenerales.Text = "Editar Datos Generales del Movimiento";
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).BuscadorMovimientoVisible = true;
            ((CarritoViewModel)this.BindingContext).BusquedaMovimientosSinResultados = false;
            ((CarritoViewModel)this.BindingContext).ListaMovimientosBusquedaVisible = true;
            ((CarritoViewModel)this.BindingContext).BotonesGuardarVisibles = false;
           // TituloMovimiento.Text = "Agrega Movimientos";
         }
        /*
        private void TapGestureRecognizer_MostrarMovimientoAgregar(object sender, EventArgs e)
        {
            var stack = sender as StackLayout;
            _ = AgregarMovimientostack);
        }

        public void AgregarMovimientos(StackLayout stack)
        {
            TBAALMMOV data = stack.BindingContext as TBAALMMOV;
            BtnAgregarArticuloPedido.Text = "Agregar";
            ((CarritoViewModel)this.BindingContext).NuevoMovimiento true;
            ((CarritoViewModel)this.BindingContext).EditarMovimiento(data);
        }
        */
        protected override bool OnBackButtonPressed()
        {
            // true or false to disable or enable the action
            if (((CarritoViewModel)this.BindingContext).BuscadorMovimientosVisible == true)
            {
                ((CarritoViewModel)this.BindingContext).BuscadorMovimientosVisible = false;
                ((CarritoViewModel)this.BindingContext).EdicionMovimientosVisible = false;

                ((CarritoViewModel)this.BindingContext).BotonesGuardarVisibles = true;

                if (((CarritoViewModel)this.BindingContext).IDALMMOV > 0)
                {
                    TituloPedidos.Text = "Edita Pedido " + ((CarritoViewModel)this.BindingContext).FOLIO;
                }
                else
                {
                    TituloPedidos.Text = "Nuevo Pedido";
                }

                return true;
            }
            else
            {
                PreguntarSalir();
                return true;
                //return base.OnBackButtonPressed();
            }
        }


        private void CerrarEncabezadoPedido(object sender, EventArgs e)
        {
            expander_datos_movimiento.IsExpanded = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).BuscadorArticulosVisible = false;
            ((CarritoViewModel)this.BindingContext).EdicionMovimientosVisible = false;

            ((CarritoViewModel)this.BindingContext).BotonesGuardarVisibles = true;
            if (((CarritoViewModel)this.BindingContext).IDALMMOV > 0)
            {
                TituloPedidos.Text = "Edita Pedido " + ((CarritoViewModel)this.BindingContext).FOLIO;
            }
            else
            {
                TituloPedidos.Text = "Nuevo Pedido";
            }
        }

/*
        private void TapGestureRecognizer_NotasPie(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).VisualizaNotasPie = true;
            EditorNotasPie.Focus();
        }

        private void TapGestureRecognizer_EditarArticuloPedido(object sender, EventArgs e)
        {
            if (((CarritoViewModel)this.BindingContext).EditarMovimiento == true)
            {
                var stack = sender as StackLayout;
                EditarArticuloPedido(stack);
            }
        }

        public void EditarArticuloPedido(StackLayout stack)
        {
            TBAALMMOV data = stack.BindingContext as TBAALMMOV;
            BtnAgregarArticuloPedido.Text = "Actualizar";
            ((CarritoViewModel)this.BindingContext).NuevoMovimiento = false;
            ((CarritoViewModel)this.BindingContext).EditarMovimientos(data);
        }
        */
        private void TapGestureRecognizer_AumentarCantidadArticulo(object sender, EventArgs e)
        {
            var stack = sender as StackLayout;
            TBAALMMOV data = stack.BindingContext as TBAALMMOV;

            ((CarritoViewModel)this.BindingContext).CambiarCantidadMovimiento(data.IDALMMOV, true);
        }

        private void TapGestureRecognizer_DisminuirCantidadArticulo(object sender, EventArgs e)
        {
            var stack = sender as StackLayout;
            TBAALMMOV data = stack.BindingContext as TBAALMMOV;

            ((CarritoViewModel)this.BindingContext).CambiarCantidadMovimiento(data.IDALMMOV, false);
        }

        private void TapGestureRecognizer_CerrarEdcionArticulo(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).CerrarEdicionMovimiento();
        }

        private void TapGestureRecognizer_AgregarArticulo(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).AgregarMovimiento();
        }

        /*
        private void TapGestureRecognizer_AgregarCliente(object sender, EventArgs e)
        {
            if (((CarritoViewModel)this.BindingContext).EditarVenta == true)
            {
                ((CarritoViewModel)this.BindingContext).TituloVentanaEdicionCliente = "Agrega un nuevo cliente";
                ((CarritoViewModel)this.BindingContext).EditorClienteVisible = true;
                ((CarritoViewModel)this.BindingContext).EditandoCliente = false;
                ((CarritoViewModel)this.BindingContext).NombreClienteEditar = "";
                ((CarritoViewModel)this.BindingContext).CodigoClienteEditar = "";
            }
        }*/
        private void TapGestureRecognizer_EditarMovimiento(object sender, EventArgs e)
        {
            if (((CarritoViewModel)this.BindingContext).EditarMovimiento == true)
            {
                ((CarritoViewModel)this.BindingContext).TituloVentanaEdicionCliente = "Editar Movimiento";
                ((CarritoViewModel)this.BindingContext).MostrarMovimientoEditar();
            }
        }
        private void TapGestureRecognizer_OfertasProducto(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).MostrarOfertasProducto();
        }

        private void TapGestureRecognizer_CerrarOfertaProducto(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).DetalleOfertaVisible = false;
        }



        private void TapGestureRecognizer_GuardarPedido(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).GuardarMovimiento();
        }

        private void TapGestureRecognizer_AfectarPedido(object sender, EventArgs e)
        {
            ((CarritoViewModel)this.BindingContext).AfectarMovimiento();
        }
    }
}
