using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05_Execicios.Domain
{
    public class Contato
    {
        public Contato(int Id, string nome, string telefone)
        {
            this.Id = Id;
            this.Nome = nome;
            this.Telefone = telefone;
        }

        public int Id { get; set; }
        public String Nome { get; set; }
        public string Telefone { get; set; }

    }
    
}