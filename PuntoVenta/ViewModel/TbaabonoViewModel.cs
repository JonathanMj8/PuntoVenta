using PuntoVenta.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta.ViewModel
{
    public class TbaabonoViewModel
    {
        public static async Task<int> GuardarTaabono()
        {
            int result = 0;
            TBAABONO newtaabono = new TBAABONO()
            {
                IDVENTA = 1,
                IDCLIENTE = 1,
                IDFPAGO = 1,
                IDCAJERO = 1,
                FECHA = DateTime.Now,
                TIPODOC = "A",
                FOLIODOC = "0001",
                FOLIOABONO = 1,
                IMPORTE = (decimal?)101.25,
                OBSERVACIONES = "Ninguna",
                AFECTO = 1,
                HORAABONO = "12 pm",
                CORTEZ = "T",
                FECHACORTE = DateTime.Now,
                CONCEPTO = "Ejemplo",
                IDTIPODOC = 1,
                IDESTATUS = 1,
                FACTURADO = 1,
                IDVENTAPAGOCFDI = 1,
                IDCORTE = 1,
                IDSUCURSAL = 1,
                IDFACTURO = 1,
                IDAPLICACION = Guid.NewGuid(),
                USUARIOIDAPP = Guid.NewGuid(),
                IDFACTUROIDAPP = Guid.NewGuid(),
                IDVENTAPAGOCFDIIDAPP = Guid.NewGuid()
                
            };
            result = await App.Database.SaveTbaabono(newtaabono);
            return result;
        }
        public static async Task<List<TBAABONO>> GetAbonoAll()
        {
            List<TBAABONO> abonoList = null;
            abonoList = await App.Database.GetAllTbaabono();
            return abonoList;
        }
        public static async Task<TBAABONO> GetAbonoId(int id=1)
        {
            TBAABONO abonoId = null;
            abonoId = await App.Database.GetIdTbaabono(id);
            return abonoId;
        }
        public static async Task<int> DeleteAbonoId(int id = 3)
        {
            int result = 0;
            var abonoDeleteId = await App.Database.GetIdTbaabono(id);
            if(abonoDeleteId != null)
            {
                await App.Database.DeleteTbaabono(abonoDeleteId);
            }
            return result;
        }
    }
}
