using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    [Table("tipo_ventas")]
    public class Tipo_ventas
    {
        [Key] 
        public int id { get; set; }
        public String descripcion { get; set; }
        public DateTime fecha { get; set; }
        public int id_usuario { get; set; }
    }

}
