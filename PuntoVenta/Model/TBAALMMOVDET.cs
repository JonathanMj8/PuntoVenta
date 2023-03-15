using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PuntoVenta.Model
{
    public class TBAALMMOVDET
    {
        [PrimaryKey, AutoIncrement]
        public int IDALMMOVDET { get; set; }
        public int? IDALMMOV { get; set; }
        public int? IDPRODUCTO { get; set; }
        public decimal? CANTIDAD {get; set;}
        public decimal? COSTO { get; set; }
        public decimal? IMPORTE { get; set; }
        public decimal? SUBTOTALU { get; set; }
        public decimal? IVAU { get; set; }
        public decimal? SUBTOTAL { get; set; }
        public decimal? TOTALIVA { get; set; }
        public decimal? IVA { get; set; } 
        [MaxLength(50)]
        public string LOTE { get; set; } 
        public DateTime FECHACAD { get; set; }
        public int? IDLOTE { get; set; }
        public short? ANTIBIOTICO { get; set; } 
        [MaxLength(50)]
        public string UMEDIDA { get; set; } 
        public short? KIT { get; set; }
        public decimal? EXISTENCIA { get; set; }
        public decimal? FALTANTE { get; set; }
        public decimal? SOBRANTE { get; set; }
        public Guid IdAplicacion { get; set; }
        public decimal? IEPS { get; set; }
        public decimal? TOTALIESPS { get; set; }
        public decimal? COSTOCALC { get; set; }

    }
}
