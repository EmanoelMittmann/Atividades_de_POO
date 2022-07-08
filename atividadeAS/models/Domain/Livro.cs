using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class Livro
    {

       public int Id_Livro { get; set; }
        public string Titulo { get; set; }
        public int Num_edit { get; set; }
        public int Volume { get; set; }
        public EditoraDomain Editora {get; set;}
        public int EditoraId { get; set; }
        public Genero Genero{get; set;}
        public int GeneroId { get; set; }

        public EmprestimoDomain Emprestimo { get; set; }

        public IList<Autor> Autores { get; set; }
}
}