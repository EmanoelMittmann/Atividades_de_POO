using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class Autor
    {
        public int Id_Autor{ get; set; }
        public string Nome{ get; set; }
        public IList<Livro> Livros { get; set; }
    }
}