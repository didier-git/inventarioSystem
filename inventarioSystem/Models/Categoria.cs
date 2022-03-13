using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    [Table("categorias")]
    public class Categoria
    {
        [Key]
        public int id { get; set; }
        public string descripcion { get; set; }
        public string fecha {get; set;}
        public int id_usuario {get; set;}

    }
}
