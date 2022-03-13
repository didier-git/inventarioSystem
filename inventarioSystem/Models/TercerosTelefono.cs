using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{

    [Table("tercerosxtelefono")]
    public class TercerosTelefono
    {
        [Key]
        public int id { get; set; }
        public int id_cliente { get; set; }
        public int numero { get; set; }
        public String tipo { get; set; }
    }

}
