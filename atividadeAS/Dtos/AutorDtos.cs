using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;

namespace atividadeAS.Dtos
{
    public class AutorDtos
    {
        public int Id_Autor{ get; set; }
        public string nome{ get; set; }

        public AutorDtos(Autor entity)
        {
            Id_Autor = entity.Id_Autor;
            nome = entity.Nome;
        }
        public AutorDtos()
        {
            
        }
    }
}