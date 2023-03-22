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
            BindingContext = new MainpageViewModel(Navigation);
            
        }

        #region TBAABONO
        private void insertAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = TbaabonoViewModel.GuardarTaabono();
        }
        private void getAllAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = TbaabonoViewModel.GetAbonoAll();
        }
        private void getIdAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = TbaabonoViewModel.GetAbonoId();
        }
        private void deleteAbonoBtn_Clicked(object sender, EventArgs e)
        {
            _ = TbaabonoViewModel.DeleteAbonoId();
        }

        #endregion
        #region TBAALMMOV
        private void insertAlmmov_Clicked(object sender, EventArgs e)
        {
             _= TbaalmmovViewModel.GuardarAllmmov();
        }

        private void getAlmmovAll_Clicked(object sender, EventArgs e)
        {
           _ = TbaalmmovViewModel.GetTbaalmmovAll();
        }

        private void getAlmmovId_Clicked(object sender, EventArgs e)
        {
          //  _ = Tbaalmmov.GetTbaalmmovId();
        }

        private void deleteAlmmov_Clicked(object sender, EventArgs e)
        {
            _ = TbaalmmovViewModel.DeleteTbaalmmovId();
        }
        #endregion
        #region TBAALMMOVDET

        private void insertAlmmovdet_Clicked(object sender, EventArgs e)
        {
            //_ = Tbaalmmovdet.GuardarTbaalmmovdet();
        }

        private void getAlmmovdetAll_Clicked(object sender, EventArgs e)
        {
            _ = TbaalmmovdetViewModel.GetTbaalmmovdetAll();
        }

        private void getAlmmovdetId_Clicked(object sender, EventArgs e)
        {
            _ = TbaalmmovdetViewModel.GetIdTbaalmmovdet();
        }

        private void deleteAlmmovdet_Clicked(object sender, EventArgs e)
        {
            _ = TbaalmmovdetViewModel.DeleteTbaalmmovdetId();
        }
        #endregion
        #region TBAEXISTECIA
        private void Button_ClickedAsync(object sender, EventArgs e)
        {
            _ = TbaexistenciaViewModel.GuardarExistencia();
        }
        private void getExistenciaBtn_Clicked(object sender, EventArgs e)
        {
            _ = TbaexistenciaViewModel.GetExistenciaAll();
        }
        private void btnExistenciaGet_Clicked(object sender, EventArgs e)
        {
           _ = TbaexistenciaViewModel.GetExistenciaId();
        }

        private void deleteExistenciaBtn_Clicked(object sender, EventArgs e)
        {
           _ = TbaexistenciaViewModel.DeleteExistenciaId();
        }
        #endregion

        #region TBASUCURSAL
        private void insertSucursal_Clicked(object sender, EventArgs e)
        {
            _ = TbasucursalViewModel.GuardarSucursal();
        }

        private void getAllSucursalAll_Clicked(object sender, EventArgs e)
        {
            _ = TbasucursalViewModel.GetSucursalAll();
        }

        private void getSucursalId_Clicked(object sender, EventArgs e)
        {
            _ = TbasucursalViewModel.GetSucursalId();
        }

        private void deleteSucursal_Clicked(object sender, EventArgs e)
        {
            _ = TbasucursalViewModel.DeleteSucursalId();
        }
        #endregion

        #region TBAESTATUS
        private void insertEstatus_Clicked(object sender, EventArgs e)
        {
            _ = TbaestatusViewModel.Guardarestatus();
        }

        private void getEstatusAll_Clicked(object sender, EventArgs e)
        {
            _ = TbaestatusViewModel.GetAllEstatus();
        }

        private void getEstatusId_Clicked(object sender, EventArgs e)
        {
            _ = TbaestatusViewModel.GetAllEstatusId();
        }

        private void deleteEstatus_Clicked(object sender, EventArgs e)
        {
            _= TbaestatusViewModel.DeleteEstatusId();
        }
        #endregion

        #region TBAMOTIVOMOV
        private void insertMotivomov_Clicked(object sender, EventArgs e)
        {
            _ = TbamotivomovViewModel.GuardarMotivomov();
        }

        private void getAllMotivomovAll_Clicked(object sender, EventArgs e)
        {
            _ = TbamotivomovViewModel.GetMotivomovAll();
        }

        private void getMotivomovId_Clicked(object sender, EventArgs e)
        {

        }

        private void deleteMotivomov_Clicked(object sender, EventArgs e)
        {
            _ = TbamotivomovViewModel.DeleteMotivomovId();
        }
        #endregion

        
    }
}
