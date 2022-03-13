using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Key] 
        public int id { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string estado { get; set; }
        public int id_perfil { get; set; }
    }
}
