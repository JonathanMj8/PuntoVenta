using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PuntoVenta.Model;
using System.Linq;
using System.Collections.ObjectModel;

namespace PuntoVenta.Services
{
    public class Database
    {
        SQLiteAsyncConnection database;
        public Database(string path)
        {
            database = new SQLiteAsyncConnection(path);
            //creacion de las tablas
            database.CreateTableAsync<TBAABONO>().Wait();
            database.CreateTableAsync<TBAALMMOV>().Wait();
            database.CreateTableAsync<TBAALMMOVDET>().Wait();
            database.CreateTableAsync<TBAEXISTENCIA>().Wait();
            database.CreateTableAsync<TBASUCURSAL>().Wait();
            database.CreateTableAsync<TBAMOTIVOMOV>().Wait();
            database.CreateTableAsync<TBAESTATUS>().Wait();
        }

        #region TBAABONO
        //Mostrar solo uni
        public Task<TBAABONO> GetIdTbaabono(int id)
        {
            return database.Table<TBAABONO>().FirstOrDefaultAsync(p => p.IDABONO == id);
        }
        //Mostrar
        public Task<List<TBAABONO>> GetAllTbaabono()
        {
            return database.Table<TBAABONO>().ToListAsync();
        }
        //Insertar
        public Task<int> SaveTbaabono(TBAABONO item)
        {
            if (item.IDABONO != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        //Eliminar
        public Task<int> DeleteTbaabono(TBAABONO item)
        {
            return database.DeleteAsync(item);
        }
        #endregion

        #region TBAALMMOV 
        public async Task<List<TBAALMMOV>> GetAll()
        {
            //PONER INDICADORES DE TIPO STRING DE LAS TABLAS EXTERNAS EN EL MODELO PRINCIPAL Y PODER HACER EL BINDING
            var qry = await database.QueryAsync<TBAALMMOV>(@"SELECT TBAALMMOV.FECHA, TBAALMMOV.FOLIO, TBAESTATUS.DESCRIPCION ESTATUS, TBAESTATUS.COLOR ESTATUSCOLOR, TBASUCURSAL.NOMBRE SUCURSAL, TBAMOTIVOMOV.DESCRIPCION MOTIVO FROM TBAALMMOV INNER JOIN TBAESTATUS ON TBAALMMOV.IDESTATUS = TBAESTATUS.IDESTATUS INNER JOIN TBASUCURSAL ON TBAALMMOV.IDSUCURSAL = TBASUCURSAL.IDSUCURSAL LEFT JOIN TBAMOTIVOMOV ON TBAALMMOV.IDMOTIVOMOV = TBAMOTIVOMOV.IDMOTIVOMOV");

            return qry;
        }
        public Task<TBAALMMOV> GetTbaalmmovId(int id)
        {
            return database.Table<TBAALMMOV>().FirstOrDefaultAsync(p => p.IDALMMOV == id);
        }
        public Task<List<TBAALMMOV>> GetAllTbaalmmov()
        {
           return database.Table<TBAALMMOV>().ToListAsync();
        } 
        public Task<int> SaveTbaalmmov(TBAALMMOV item)
        {
            if (item.IDALMMOV != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteTbaalmmov(TBAALMMOV item)
        {
            return database.DeleteAsync(item);
        } 
        #endregion

        #region TBAALMMOVDET
        public Task<TBAALMMOVDET> GetIdTbaalmmovdet(int id)
        {
            return database.Table<TBAALMMOVDET>().FirstOrDefaultAsync(p => p.IDALMMOVDET == id);
        }
        public Task<List<TBAALMMOVDET>> GetAllTbaalmmovdet()
        {
            return database.Table<TBAALMMOVDET>().ToListAsync();
        }
        public Task<int> SaveTbaalmmovdet(TBAALMMOVDET item)
        {
            if (item.IDALMMOVDET != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteTbaalmmovdet(TBAALMMOVDET item){
            return database.DeleteAsync(item);
        }
        #endregion

        #region TBAEXISTENCIA
        //Traer solo uno
        public Task<TBAEXISTENCIA> GetTbaexistencia(int id)
        {
            return database.Table<TBAEXISTENCIA>().FirstOrDefaultAsync(p => p.IDEXISTENCIA == id);
        }
        public Task<List<TBAEXISTENCIA>> GetTbaexistenciaAll()
        {
            return database.Table<TBAEXISTENCIA>().ToListAsync();
        }
        public Task<int> SaveTbaexistencia(TBAEXISTENCIA item)
        {
            if (item.IDEXISTENCIA != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteTbaexistencia(TBAEXISTENCIA item)
        {
            return database.DeleteAsync(item);
        }
        #endregion

        #region TBASUCURSAL
        public Task<TBASUCURSAL> GetIdTbasucursal(int id)
        {
            return database.Table<TBASUCURSAL>().FirstOrDefaultAsync(p => p.IDSUCURSAL == id);
        }
        public Task<List<TBASUCURSAL>> GetAllTbasucursal()
        {
            return database.Table<TBASUCURSAL>().ToListAsync();
        }
        public Task<int> SaveTbasucursal(TBASUCURSAL item)
        {
            if (item.IDSUCURSAL != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteTbasucursal(TBASUCURSAL item)
        {
            return database.DeleteAsync(item);
        }
        #endregion

        #region TBAMOTIVOMOV
        public Task<TBAMOTIVOMOV> GetTbamotivomovId(int id)
        {
            return database.Table<TBAMOTIVOMOV>().FirstOrDefaultAsync(p => p.IDMOTIVOMOV == id);
        }
        public Task<List<TBAMOTIVOMOV>> GetAllTbamotivomov()
        {
            return database.Table<TBAMOTIVOMOV>().ToListAsync();
        }
        public Task<int> SaveTbamotivomov(TBAMOTIVOMOV item)
        {
            if (item.IDMOTIVOMOV != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteTbamotivomov(TBAMOTIVOMOV item)
        {
            return database.DeleteAsync(item);
        }
        #endregion

        #region TBAESTATUS
        public Task<TBAESTATUS> GetTbaestatusId(int id)
        {
            return database.Table<TBAESTATUS>().FirstOrDefaultAsync(p => p.IDESTATUS == id);
        }
        public Task<List<TBAESTATUS>> GetAllTbaestatus()
        {
            return database.Table<TBAESTATUS>().ToListAsync();
        }
        public Task<int> SaveTbaestatus(TBAESTATUS item)
        {
            if (item.IDESTATUS != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteTbaestatus(TBAESTATUS item)
        {
            return database.DeleteAsync(item);
        }
        #endregion
         
    }
}
