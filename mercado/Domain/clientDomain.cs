using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mercado.Domain;

namespace mercado.Domain
{
    public class clientDomain
    {
        public clientDomain(int id_cliente ) 
        {
            Id_cliente = id_cliente;
            Compras = new List<estoqueDomain>();
   
        }
        public int Id_cliente { get; set; }
        
        public List<estoqueDomain> Compras{get; set; }
    }
}