using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    public class Gastos
    {
        public int id { get;set;}
        public string descripcion{get;set;}
        public double monto{get;set;}
        public DateTime fechaRegistro{get;set;}
        public DateTime fecha{get;set;}
        public int idUsuario{get;set;}

    }
}
