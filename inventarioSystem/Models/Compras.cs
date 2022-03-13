using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventarioSystem.Models
{
    public class Compras
    {
        public int id { get; set; }
        public int idComprobante{get;set;}
        public int idProvedor{get;set;}
        public string numeroComprobante{get;set;}
        public double total{get;set;}
        public DateTime fecha{get;set;}
        public int idUsuario{get;set;}


    }
}
