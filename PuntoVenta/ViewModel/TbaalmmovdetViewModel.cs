using PuntoVenta.Model;
using PuntoVenta.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PuntoVenta.ViewModel
{
    public class TbaalmmovdetViewModel : Baseviewmodel
    {
        #region VARIABLES
        public ObservableCollection<TBAALMMOVDET> Allmmmovdet { get; set; }
        public int? IDALMMOV
        {
            get
            {
                return IDALMMOV;
            }
            set
            {
                if (IDALMMOV != value)
                {
                    IDALMMOV = value;
                    OnPropertyChanged("IDALMMOV");
                }
            }
        }
        public int? IDPRODUCTO
        {
            get
            {
                return IDPRODUCTO;
            }
            set
            {
                if (IDPRODUCTO != value)
                {
                    IDPRODUCTO = value;
                    OnPropertyChanged("IDPRODUCTO");
                }
            }
        }
        public decimal? CANTIDAD
        {
            get
            {
                return CANTIDAD;
            }
            set
            {
                if (CANTIDAD != value)
                {
                    CANTIDAD = value;
                    OnPropertyChanged("CANTIDAD");
                }
            }
        }
        public decimal? COSTO
        {
            get
            {
                return COSTO;
            }
            set
            {
                if (COSTO != value)
                {
                    COSTO = value;
                    OnPropertyChanged("COSTO");
                }
            }
        }
        public decimal? IMPORTE
        {
            get
            {
                return IMPORTE;
            }
            set
            {
                if (IMPORTE != value)
                {
                    IMPORTE = value;
                    OnPropertyChanged("IMPORTE");
                }
            }
        }
        public decimal? SUBTOTALU
        {
            get
            {
                return SUBTOTALU;
            }
            set
            {
                if (SUBTOTALU != value)
                {
                    SUBTOTALU = value;
                    OnPropertyChanged("SUBTOTALU");
                }
            }
        }
        public decimal? IVAU
        {
            get
            {
                return IVAU;
            }
            set
            {
                if (IVAU != value)
                {
                    IVAU = value;
                    OnPropertyChanged("IVAU");
                }
            }
        }
        public decimal? SUBTOTAL {
            get
            {
                return SUBTOTAL;
            }
            set
            {
                if (SUBTOTAL != value)
                {
                    SUBTOTAL = value;
                    OnPropertyChanged("SUBTOTAL");
                }
            }
        }
        public decimal? TOTALIVA {
            get
            {
                return TOTALIVA;
            }
            set
            {
                if (TOTALIVA != value)
                {
                    TOTALIVA = value;
                    OnPropertyChanged("TOTALIVA");
                }
            }
        }
        public decimal? IVA {
            get
            {
                return IVA;
            }
            set
            {
                if (IVA != value)
                {
                    IVA = value;
                    OnPropertyChanged("IVA");
                }
            }
        }
        public string LOTE 
        {
            get
            {
                return LOTE;
            }
            set
            {
                if (LOTE != value)
                {
                    LOTE = value;
                    OnPropertyChanged("LOTE");
                }
            }
        }
        public DateTime FECHACAD
        {
            get
            {
                return FECHACAD;
            }
            set
            {
                if (FECHACAD != value)
                {
                    FECHACAD = value;
                    OnPropertyChanged("FECHACAD");
                }
            }
        }
        public int? IDLOTE {
            get
            {
                return IDLOTE;
            }
            set
            {
                if (IDLOTE != value)
                {
                    IDLOTE = value;
                    OnPropertyChanged("IDLOTE");
                }
            }
        }
        public short? ANTIBIOTICO {
            get
            {
                return ANTIBIOTICO;
            }
            set
            {
                if (ANTIBIOTICO != value)
                {
                    ANTIBIOTICO = value;
                    OnPropertyChanged("ANTIBIOTICO");
                }
            }
        }
        public string UMEDIDA {
            get
            {
                return UMEDIDA;
            }
            set
            {
                if (UMEDIDA != value)
                {
                    UMEDIDA = value;
                    OnPropertyChanged("UMEDIDA");
                }
            }
        }

        #endregion
        #region CONSTRUCTOR
        public TbaalmmovdetViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _ = AddTbaalmmovdetAsync();

        }
        #endregion
        #region METODOS
        //NAVEGACION DE PAGINAS
        public async Task AddTbaalmmovdetAsync()
        {
            Allmmmovdet = new ObservableCollection<TBAALMMOVDET>(await App.Database.GetAllTbaalmmovdet());
        }
        public async Task AgregarCommand()
        {
            await Navigation.PushAsync(new TbaalmmovdetAgregar());
        }

        public static async Task<int> GuardarTbaalmmovdet()
        {
            int result = 0;
            TBAALMMOVDET modelo = new TBAALMMOVDET()
            {
                IDALMMOV = 1,
                IDPRODUCTO = 1,
                CANTIDAD = 2,
                COSTO = 14,
                IMPORTE = 12,
                SUBTOTAL = 100,
                TOTALIVA = 12,
                IVA = 12,
                LOTE = "A",
                FECHACAD = DateTime.Now,
                IDLOTE = 1,
                ANTIBIOTICO = 1,
                UMEDIDA = "CM",
                KIT = 1,
                EXISTENCIA = (decimal)40.5,
                FALTANTE = 1,
                SOBRANTE = (decimal)10.5,
                IdAplicacion = Guid.NewGuid(),
                IEPS = (decimal)10.5,
                TOTALIESPS = (decimal)10.5,
                COSTOCALC = (decimal)20.5
            };
            result = await App.Database.SaveTbaalmmovdet(modelo);
            return result;
        }
        public static async Task<List<TBAALMMOVDET>> GetTbaalmmovdetAll()
        {
            List<TBAALMMOVDET> allmmovdetList = null;
            allmmovdetList = await App.Database.GetAllTbaalmmovdet();
            return allmmovdetList;
        }
        public static async Task<TBAALMMOVDET> GetIdTbaalmmovdet(int id = 1)
        {
            TBAALMMOVDET tbaalmmovdetId = null;
            tbaalmmovdetId = await App.Database.GetIdTbaalmmovdet(id);
            return tbaalmmovdetId;
        }
        public static async Task<int> DeleteTbaalmmovdetId(int id = 1)
        {
            int result = 0;
            var aalmmovdetDeleteId = await App.Database.GetIdTbaalmmovdet(id);
            if (aalmmovdetDeleteId != null)
            {
                await App.Database.DeleteTbaalmmovdet(aalmmovdetDeleteId);
            }
            return result;
        }
        #endregion

        #region COMMANDOS
        //COMANDO PARA EL BOTON DE NEXTPAGE
         public ICommand NavigationAgregarCommand => new Command(async () => await AgregarCommand());
        public ICommand GuardarCommand => new Command(async () => await GuardarTbaalmmovdet());

        #endregion
    }
}
