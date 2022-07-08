using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class EmprestimoDomain
    {
        public int Id_empres { get; set; }
        public Livro Livro{ get; set;}
        public int LivroId { get; set; }
        public Usuario User{ get; set;}
        public int UserId { get; set; }
        public DateTime data_emprestimo{ get; set;}
        public DateTime data_entrega{ get; set;}
        public int prazo{ get; set;}
    }
}