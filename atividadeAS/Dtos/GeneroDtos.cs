using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;

namespace atividadeAS.Dtos
{
    public class GeneroDtos
    {
        public int Id_Genero{ get; set; }
        public string Nome{ get; set; }

        public GeneroDtos(Genero entity)
        {
            Id_Genero = entity.Id_Genero;
            Nome = entity.nome;
        }
        public GeneroDtos()
        {

        }
    }
}