using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.WebApi.Viewsmodels
{
    public class LivroViewModels
    {
         public int Id_Livro { get; set; }
        public string Titulo { get; set; }
        public int Num_edit { get; set; }
        public int Volume { get; set; }
    }
}