using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    [Table("terceros")]
    public class Terceros
    {

        [Key]
        public int id { get; set; }

        public String tpo_documento { get; set; }

        public String numero { get; set; }

        public String primer_nombre { get; set; }

        public String segundo_nombre { get; set; }

        public String primer_apellido { get; set; }

        public String segundo_apellido { get; set; }

        public String direccion { get; set; }

        public String correo { get; set; }

        public DateTime fecha { get; set; }

        public int id_usuario { get; set; }

    }

}
