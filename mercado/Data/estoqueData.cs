using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mercado.Domain;

namespace mercado.Data
{
    public class estoqueData
    {
        private List<clientDomain> compras = new List<clientDomain>(); 
        public void save(clientDomain estoque)
        {
            compras.Add(estoque);
        }
        public List<clientDomain> getall()
        {
            return compras;
        }
        public 
    }
}