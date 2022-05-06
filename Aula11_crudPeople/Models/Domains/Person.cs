using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula11_crudPeople.Models.Domains
{
    public class Person
    {
        public Person(){}
        public Person(int id, string nome, string fone)
        {
            Id = id;
            Nome = nome;
            Fone = fone;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
                
    }
}