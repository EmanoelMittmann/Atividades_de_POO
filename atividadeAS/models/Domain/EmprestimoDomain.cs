using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class Emprestimo
    {
        public Emprestimo(LivroDomain id_Livro, Usuario user_Cpf, DateTime data_emprestimo, DateTime data_entrega, int prazo)
        {
            Id_Livro = id_Livro;
            User_Cpf = user_Cpf;
            this.data_emprestimo = data_emprestimo;
            this.data_entrega = data_entrega;
            this.prazo = prazo;
        }

        public LivroDomain Id_Livro{ get; set;}
        public Usuario User_Cpf{ get; set;}
        public DateTime data_emprestimo{ get; set;}
        public DateTime data_entrega{ get; set;}
        public int prazo{ get; set;}
    }
}