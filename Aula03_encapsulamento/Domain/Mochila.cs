using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_encapsulamento.Domain
{
    public class Mochila
    {

        public Mochila(int id, string descricao, decimal preco, int quantMax, string eCor) 
        {
            this.Id = id;
    this.Descricao = descricao;
    this.Preco = preco;
    this.QuantMax = quantMax;
    this.eCor = cor;
   
        }
        public int Id { get; private set; }

        public string Descricao{ get; private set; }

        public decimal Preco { get; set; }

        public int QuantMax { get; private set; }

        public string eCor { get; private set; }
        
        public List<Item> Itens { get; set; }
    }
}