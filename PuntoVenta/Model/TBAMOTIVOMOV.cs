using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PuntoVenta.Model
{
    public class TBAMOTIVOMOV
    {
        [PrimaryKey, AutoIncrement]
        public int IDMOTIVOMOV { get; set; }
        [MaxLength(50)]
        public string DESCRIPCION { get; set; }
        public int? IDTIPOMOV {get; set;}
    }
}
