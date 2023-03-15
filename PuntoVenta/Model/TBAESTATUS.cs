using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PuntoVenta.Model
{
   
    public class TBAESTATUS
    {
        [PrimaryKey, AutoIncrement]
        public int IDESTATUS { get; set; }

        [MaxLength (50)]
        public string DESCRIPCION { get; set; }

        [MaxLength(7)]
        public  string COLOR { get; set; }

        [MaxLength(50)]
        public  string CODIGO { get; set; }
        public  int? IDTIPOESTATUS { get; set; }
        public bool? PERMITEFACTURAR { get; set; }

        [MaxLength (200)]
        public string ESTATUSCOMENTARIO { get; set; }

        [MaxLength(20)]
        public string COLORFUENTEESTATUS { get; set; }
        public  int? IDESTATUSRELACION { get; set; }

    }
}
