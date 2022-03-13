using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    public class Productos
    {
        public int id { get ;set;}
        public int idCategoria{get ;set;}
        public String descripcion{get ;set;}
        public byte[] foto{get ;set;}
        public String codigo{get ;set;}
        public Double precioVenta{get ;set;}
        public Double precioCompra{get ;set;}
        public DateTime fecha{get ;set;}
        public int idUsuario{get ;set;}
    }
}
