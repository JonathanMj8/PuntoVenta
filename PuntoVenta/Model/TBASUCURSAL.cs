using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace PuntoVenta.Model
{
    public class TBASUCURSAL
    {
        [PrimaryKey, AutoIncrement]
        public int IDSUCURSAL { get; set; }
        [MaxLength(200)]
        public string NOMBRE { get; set; }
        [MaxLength(200)]
        public string DOMICILIO { get; set; }
        [MaxLength(50)]
        public string TELEFONO { get; set; }
        [MaxLength(200)]
        public string OBSERVACIONES { get; set; }
        [MaxLength(200)]
        public string SERVIDOR { get; set; }
        [MaxLength(50)]
        public string CONTRASENA { get; set; }
        [MaxLength(200)]
        public string CONEXION { get; set; }
        public int? IDLISTAPRECIOS { get; set; }
        public bool? EsServidor { get; set; }
        public bool? COTIZACIONES { get; set; }
        public Guid? IDAPLICACION { get; set; }
        public bool? ESSUCURSALPROVISIONADA { get; set; }
        public int? IDSUCURSALESPADRE { get; set; }
        public bool? MOSTRARENSUCHIJAS { get; set; }
        public bool? TRASPASOS { get; set; }

    }
}
