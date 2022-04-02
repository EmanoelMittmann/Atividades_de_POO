using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_encapsulamento.Domain
{
    public class Item
    {
        public Item(int id, string nome, Mochila mochila)
        {
            this.id = id;
            this.nome = nome;
        }

        public int id { get; private set; }

        public string nome { get; private set; }

        public Mochila mochila { get; set; }
    }
}