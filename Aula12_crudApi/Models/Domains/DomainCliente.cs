using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_crudApi.Models.Domains
{
    public class DomainCliente
    {

        public DomainCliente(){}
        public DomainCliente(int id, string nome, string fone)
        {
            Id = id;
            Nome = nome;
            Fone = fone;
        }
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Fone { get; set;} = string.Empty;

    }
}