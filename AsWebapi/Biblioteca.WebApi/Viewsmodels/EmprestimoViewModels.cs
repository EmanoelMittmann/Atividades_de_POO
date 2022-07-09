using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Entity;

namespace Biblioteca.WebApi.Viewsmodels
{
    public class EmprestimoViewModels
    {
        public int Id_empres { get; set; }
        public Livro Id_Livro{ get; set;}
        public Cliente User_Cpf{ get; set;}
        public DateTime data_emprestimo{ get; set;}
        public DateTime data_entrega{ get; set;}
        public int prazo{ get; set;}
    }
}