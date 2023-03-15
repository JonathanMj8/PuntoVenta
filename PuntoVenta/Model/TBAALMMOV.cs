using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using PuntoVenta.ViewModel;
namespace PuntoVenta.Model
{
    public class TBAALMMOV
    {
        [PrimaryKey, AutoIncrement]
        public int IDALMMOV { get; set; }
        public int? IDTIPOMOV { get; set; }
        public DateTime? FECHA { get; set; }
        [MaxLength(50)]
        public string FOLIO { get; set; }
        [MaxLength(250)]
        public string OBSERVACIONES { get; set; }
        public decimal? SUBTOTAL { get; set; }
        public decimal? IVA { get; set; }
        public decimal? TOTAL { get; set; }
        public short? AFECTO { get; set; }
        public short? CANCELADO { get; set; }
        public DateTime? FECHACANCELADO { get; set; }
        public int? IDESTATUS { get; set; }
        public int? IDUSUARIO { get; set; }
        public int? IDSUCURSALESDESTINO { get; set; }
        public short? FACTURADO { get; set; }
        public int? IDCAUSA { get; set; }
        public int? IDMOTIVOMOV { get; set; }
        public Guid IdAplicacion { get; set; }
        public int? IDSUCURSALORIGEN { get; set; }
        public int? IDALMMOVRELACIONADO { get; set; }
        public bool? CONCILIADO { get; set; }
        public Guid? IDAPLICACIONRELACIONADO { get; set; }
        public int? IDSUCURSAL { get; set; }
        public Guid? USUARIOIDAPP { get; set; }
        public int? IDFACTURO { get; set; }
        public Guid? IDFACTUROIDAPP { get; set; }
        public decimal? IESPS { get; set; }
        //indicadores para el inner join
        public string ESTATUS { get; set; }
        public string SUCURSAL { get; set; }
        public string MOTIVO { get; set; }
        public string ESTATUSCOLOR { get; set; }

    }
}
