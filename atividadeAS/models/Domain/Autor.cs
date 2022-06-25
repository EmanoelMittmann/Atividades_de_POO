using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class Autor
    {
        public Autor(int id_Autor, string nome)
        {
            Id_Autor = id_Autor;
            this.nome = nome;
        }

        public int Id_Autor{ get; set; }
        public string nome{ get; set; }
    }
}