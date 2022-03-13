using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    public class Inventario
    {
        public int id { get; set;}
        public int idProducto{get; set;}
        public int entradas{get; set;}
        public int salidas{get; set;}
        public int existencias{get; set;}
        public DateTime fecha{get; set;}
        public int idUsuario{get; set;}

    }
}
