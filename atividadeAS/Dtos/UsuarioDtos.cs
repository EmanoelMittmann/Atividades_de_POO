using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;

namespace atividadeAS.Dtos
{
    public class UsuarioDtos
    {
        public int Id_user{get; set;}
        public int CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set;}
        public string Telefone { get; set;}
        public string Email { get; set;}

         public UsuarioDtos(Usuario entity)
        {
            Id_user = entity.Id_user;
            CPF = entity.CPF;
            Nome = entity.Nome;
            Endereco = entity.Endereco;
            Telefone = entity.Telefone;
            Email = entity.Email;
        }
        public UsuarioDtos()
        {
            
        }
    }
}