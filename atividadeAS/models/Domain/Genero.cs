using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class Genero
    {
        public int Id_Genero{ get; set; }
        public string nome{ get; set; }
        public IList<Livro> Livros {get;set;}
    }
}