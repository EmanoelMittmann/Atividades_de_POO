using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Entity;

namespace Biblioteca.WebApi.Domain.Dtos
{
    public class EmprestimoDtos
    {
        public int Id_emprest { get; set; }
        public Livro Id_Livro{ get; set;}
        public Cliente User_Cpf{ get; set;}
        public DateTime data_emprestimo{ get; set;}
        public DateTime data_entrega{ get; set;}
        public int prazo{ get; set;}
    }
}