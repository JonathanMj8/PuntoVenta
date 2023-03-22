using PuntoVenta.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.ViewModel
{
    public class TbasucursalViewModel
    {
        public static async Task<int> GuardarSucursal()
        {
            int result = 0;
            TBASUCURSAL newsucursal = new TBASUCURSAL()
            {
                NOMBRE = "AUTOZONE",
                DOMICILIO ="Av.Insurgentes #34",
                TELEFONO = "311-099-222",
                OBSERVACIONES = "Ninguna",
                SERVIDOR = "A",
                CONTRASENA = "1234Auzone",
                CONEXION = "Correcto",
                IDLISTAPRECIOS = 1,
                EsServidor = true,
                COTIZACIONES = true,
                IDAPLICACION = Guid.NewGuid(),
                ESSUCURSALPROVISIONADA = true,
                IDSUCURSALESPADRE = 1,
                MOSTRARENSUCHIJAS = true,
                TRASPASOS = true
            };
            result = await App.Database.SaveTbasucursal(newsucursal);
            return result;
        }
        public static async Task<List<TBASUCURSAL>> GetSucursalAll()
        {
            List<TBASUCURSAL> listsucursal = null;
            listsucursal = await App.Database.GetAllTbasucursal();
            return listsucursal;
        }
        public static async Task<TBASUCURSAL> GetSucursalId(int id = 4)
        {
            TBASUCURSAL listidsucursal = null;
            listidsucursal = await App.Database.GetIdTbasucursal(id);
            return listidsucursal;
        }
        //Eliminar por ID
        public static async Task<int> DeleteSucursalId(int id = 1)
        {
            int result = 0;
            var eliminarsucursalid = await App.Database.GetIdTbasucursal(id);
            if (eliminarsucursalid != null)
            {
                //Delete Person
                await App.Database.DeleteTbasucursal(eliminarsucursalid);
            }
            return result;
        }
    }
}
