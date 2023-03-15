using PuntoVenta.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PuntoVenta.ViewModel
{
    public class Tbaexistencia
    {
        public static async Task<int> GuardarExistencia()
        {
            int result = 0;
            TBAEXISTENCIA newexistencia = new TBAEXISTENCIA()
            {
                EXISTENCIA = 10,
                IDEAL = 1,
                MINIMA = 1,
                IDPRODUCTO = 100,
                IdSucursal = 2,
                ULTIMACTUALIZACION = DateTime.Now
            };
            result = await App.Database.SaveTbaexistencia(newexistencia);
            return result;
        }

        public static async Task<List<TBAEXISTENCIA>> GetExistenciaAll()
        {
            List<TBAEXISTENCIA> existenciaList = null;
            existenciaList = await App.Database.GetTbaexistenciaAll();
            return existenciaList;
        }

        public static async Task<TBAEXISTENCIA> GetExistenciaId(int id = 4)
        {
            TBAEXISTENCIA existenciaId = null;
            existenciaId = await App.Database.GetTbaexistencia(id);
            return existenciaId;
        }
        //Eliminar por ID
        public static async Task<int> DeleteExistenciaId(int id = 11)
        {
            int result = 0;
            var existenciaDeleteId = await App.Database.GetTbaexistencia(id);
            if (existenciaDeleteId != null)
            {
                //Delete Person
                await App.Database.DeleteTbaexistencia(existenciaDeleteId);
            }
            return result;
        }
    }
}
