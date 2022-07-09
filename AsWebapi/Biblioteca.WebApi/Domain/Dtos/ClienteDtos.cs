using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Entity;

namespace Biblioteca.WebApi.Domain.Dtos
{
    public class ClienteDtos
    {
        public int Id_user{get; set;}
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set;}
        public string Telefone { get; set;}
        public string Email { get; set;}
    }
}