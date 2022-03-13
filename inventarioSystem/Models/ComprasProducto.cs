using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    public class ComprasProducto
    {
        public int id { get; set;}
        public int idCompra{get; set;}
        public int idProducto{get; set;}
        public double precio{get; set;}
        public int cantidad{get; set;}
        public DateTime fecha{get; set;}
        public int idUsuario{get; set;}
    }
}
