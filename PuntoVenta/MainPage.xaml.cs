using PuntoVenta.Views;
using PuntoVenta.ViewModel;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PuntoVenta
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainpageVM(Navigation);
            
        }

        #region TBAABONO
        private void insertAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = Tbaabono.GuardarTaabono();
        }
        private void getAllAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = Tbaabono.GetAbonoAll();
        }
        private void getIdAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = Tbaabono.GetAbonoId();
        }
        private void deleteAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = Tbaabono.DeleteAbonoId();
        }

        #endregion
        #region TBAALMMOV
        private void insertAlmmov_Clicked(object sender, EventArgs e)
        {
             _= TbaalmmovMV.GuardarAllmmov();
        }

        private void getAlmmovAll_Clicked(object sender, EventArgs e)
        {
           _ = TbaalmmovMV.GetTbaalmmovAll();
        }

        private void getAlmmovId_Clicked(object sender, EventArgs e)
        {
          //  _ = Tbaalmmov.GetTbaalmmovId();
        }

        private void deleteAlmmov_Clicked(object sender, EventArgs e)
        {
            _ = TbaalmmovMV.DeleteTbaalmmovId();
        }
        #endregion
        #region TBAALMMOVDET

        private void insertAlmmovdet_Clicked(object sender, EventArgs e)
        {
            //_ = Tbaalmmovdet.GuardarTbaalmmovdet();
        }

        private void getAlmmovdetAll_Clicked(object sender, EventArgs e)
        {
            _ = Tbaalmmovdet.GetTbaalmmovdetAll();
        }

        private void getAlmmovdetId_Clicked(object sender, EventArgs e)
        {
            _ = Tbaalmmovdet.GetIdTbaalmmovdet();
        }

        private void deleteAlmmovdet_Clicked(object sender, EventArgs e)
        {
            _ = Tbaalmmovdet.DeleteTbaalmmovdetId();
        }
        #endregion
        #region TBAEXISTECIA
        private void Button_ClickedAsync(object sender, EventArgs e)
        {
            _ = Tbaexistencia.GuardarExistencia();
        }
        private void getExistenciaBtn_Clicked(object sender, EventArgs e)
        {
            _ = Tbaexistencia.GetExistenciaAll();
        }
        private void btnExistenciaGet_Clicked(object sender, EventArgs e)
        {
           _ = Tbaexistencia.GetExistenciaId();
        }

        private void deleteExistenciaBtn_Clicked(object sender, EventArgs e)
        {
           _ = Tbaexistencia.DeleteExistenciaId();
        }
        #endregion

        #region TBASUCURSAL
        private void insertSucursal_Clicked(object sender, EventArgs e)
        {
            _ = Tbasucursal.GuardarSucursal();
        }

        private void getAllSucursalAll_Clicked(object sender, EventArgs e)
        {
            _ = Tbasucursal.GetSucursalAll();
        }

        private void getSucursalId_Clicked(object sender, EventArgs e)
        {
            _ = Tbasucursal.GetSucursalId();
        }

        private void deleteSucursal_Clicked(object sender, EventArgs e)
        {
            _ = Tbasucursal.DeleteSucursalId();
        }
        #endregion

        #region TBAESTATUS
        private void insertEstatus_Clicked(object sender, EventArgs e)
        {
            _ = Tbaestatus.Guardarestatus();
        }

        private void getEstatusAll_Clicked(object sender, EventArgs e)
        {
            _ = Tbaestatus.GetAllEstatus();
        }

        private void getEstatusId_Clicked(object sender, EventArgs e)
        {
            _ = Tbaestatus.GetAllEstatusId();
        }

        private void deleteEstatus_Clicked(object sender, EventArgs e)
        {
            _= Tbaestatus.DeleteEstatusId();
        }
        #endregion

        #region TBAMOTIVOMOV
        private void insertMotivomov_Clicked(object sender, EventArgs e)
        {
            _ = Tbamotivomov.GuardarMotivomov();
        }

        private void getAllMotivomovAll_Clicked(object sender, EventArgs e)
        {
            _ = Tbamotivomov.GetMotivomovAll();
        }

        private void getMotivomovId_Clicked(object sender, EventArgs e)
        {

        }

        private void deleteMotivomov_Clicked(object sender, EventArgs e)
        {
            _ = Tbamotivomov.DeleteMotivomovId();
        }
        #endregion

        
    }
}
