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
        public EditoraDomain Id_Edit {get; set;}
        public Autor Id_Autor{get; set;}
        public Genero Id_Genero{get; set;}
}
}