using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PuntoVenta.Model
{
    public class TBAABONO
    {
        [PrimaryKey, AutoIncrement]
        public int IDABONO { get; set; }
        public int? IDVENTA { get; set; }
        public int? IDCLIENTE { get; set; }
        public int? IDFPAGO { get; set; }
        public int? IDCAJERO { get; set; }
        public DateTime? FECHA { get; set; } 
        [MaxLength(2)]
        public string TIPODOC { get; set; }
        [MaxLength(50)]
        public string FOLIODOC { get; set; }
        public int? FOLIOABONO { get; set; }
        public decimal? IMPORTE { get; set; } 
        [MaxLength(100)]
        public string OBSERVACIONES { get; set; }
        public short? AFECTO { get; set; } 
        [MaxLength(15)]
        public string HORAABONO { get; set; } 
        [MaxLength(10)]
        public string CORTEZ { get; set; }
        public DateTime? FECHACORTE { get; set; } 
        [MaxLength(150)]
        public string CONCEPTO { get; set; }
        public int? IDTIPODOC { get; set; }
        public int? IDESTATUS { get; set; }
        public short? FACTURADO { get; set; }
        public int? IDVENTAPAGOCFDI { get; set; }
        public int? IDCORTE { get; set; }
        public int? IDSUCURSAL { get; set; }
        public Guid? IDAPLICACION { get; set; }
        public Guid? USUARIOIDAPP { get; set; }
        public int? IDFACTURO { get; set; }
        public Guid? IDFACTUROIDAPP { get; set; }
        public Guid? IDVENTAPAGOCFDIIDAPP { get; set; }
    }
}
