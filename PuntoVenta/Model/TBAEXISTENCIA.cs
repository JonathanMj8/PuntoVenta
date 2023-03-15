using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PuntoVenta.Model
{

    public class TBAEXISTENCIA
    {
        [PrimaryKey, AutoIncrement]
        public int IDEXISTENCIA { get; set; }
        public int? IDPRODUCTO { get; set; }
        public decimal? EXISTENCIA { get; set; }
        public decimal? MINIMA { get; set; }
        public decimal? IDEAL { get; set; }
        public int? IdSucursal { get; set; }
        public DateTime? ULTIMACTUALIZACION { get; set; }
    }
}
