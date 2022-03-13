using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    [Table("ventas")]
    public class Ventas
    {
        [Key]
        public int id { get; set; }
        public int id_comprobante { get; set; }
        public int id_cliente { get; set; }
        public int id_tipopago { get; set; }
        public string numero_comprobante { get; set; }
        public double iva { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public DateTime fecha { get; set; }
        public int id_usuario { get; set; }
    }
}
