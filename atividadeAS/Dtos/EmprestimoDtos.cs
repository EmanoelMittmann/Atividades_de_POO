using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;

namespace atividadeAS.Dtos
{
    public class EmprestimoDtos
    {
        public int Id_emprest { get; set; }
        public Livro Id_Livro{ get; set;}
        public Usuario User_Cpf{ get; set;}
        public DateTime data_emprestimo{ get; set;}
        public DateTime data_entrega{ get; set;}
        public int prazo{ get; set;}

        public EmprestimoDtos(EmprestimoDomain entity)
        {
            Id_emprest = entity.Id_empres;
            Id_Livro = entity.Id_Livro;
            User_Cpf = entity.User_Cpf;
            data_emprestimo = entity.data_emprestimo;
            data_entrega = entity.data_entrega;
            prazo = entity.prazo;
        }
        public EmprestimoDtos(){
            
        }
    }
}