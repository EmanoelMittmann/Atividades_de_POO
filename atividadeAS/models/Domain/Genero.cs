using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class Genero
    {
        public Genero(int id_Genero, string nome)
        {
            Id_Genero = id_Genero;
            this.nome = nome;
        }

        public int Id_Genero{ get; set; }
        public string nome{ get; set; }
    }
}