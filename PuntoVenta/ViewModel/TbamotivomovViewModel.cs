using PuntoVenta.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.ViewModel
{
    public class TbamotivomovViewModel
    {
        public static async Task<int> GuardarMotivomov()
        {
            int result = 0;
            TBAMOTIVOMOV newmotivomov = new TBAMOTIVOMOV()
            {
                DESCRIPCION = "",
                IDTIPOMOV = 1
            };
            result = await App.Database.SaveTbamotivomov(newmotivomov);
            return result;
        }

        public static async Task<List<TBAMOTIVOMOV>> GetMotivomovAll()
        {
            List<TBAMOTIVOMOV> listmotivomov = null;
            listmotivomov = await App.Database.GetAllTbamotivomov();
            return listmotivomov;
        }

        public static async Task<TBAMOTIVOMOV> GetMotivomovId(int id = 4)
        {
            TBAMOTIVOMOV idmotivomov = null;
            idmotivomov = await App.Database.GetTbamotivomovId(id);
            return idmotivomov;
        }
        //Eliminar por ID
        public static async Task<int> DeleteMotivomovId(int id = 11)
        {
            int result = 0;
            var eliminarmotivomov = await App.Database.GetTbamotivomovId(id);
            if (eliminarmotivomov != null)
            {
                //Delete Person
                await App.Database.DeleteTbamotivomov(eliminarmotivomov);
            }
            return result;
        }
    }
}
