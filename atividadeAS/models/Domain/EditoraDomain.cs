using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class EditoraDomain
    {
        public int Id_Edit { get; set; }
        public string nome {get; set;}
        public string cidade{ get; set;}
        public IList<Livro> Livros { get; set; }
    }
}