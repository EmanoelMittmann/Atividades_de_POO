using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula11_crudPeople.Models.Domains
{
    public class City
    {
        public City(){}

        public City(int id, string nome, string estado)
        {
            Id = id;
            Nome = nome;
            Estado = estado;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
    }
}