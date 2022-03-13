using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    [Table("ventaxproductos")]
    public class VentaProducto
    {

        [Key]
        public int id { get; set; }
        public int id_venta { get; set; }
        public int id_producto { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public int id_usuario { get; set; }
    }

}
