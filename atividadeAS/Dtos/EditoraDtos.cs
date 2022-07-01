using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;

namespace atividadeAS.Dtos
{
    public class EditoraDtos
    {
        public int Id_Edit { get; set; }
        public string Nome {get; set;}
        public string Cidade{ get; set;}

        public EditoraDtos(EditoraDomain entity)
        {   
            Id_Edit = entity.Id_Edit;
            Nome = entity.nome;
            Cidade = entity.cidade;
        }
        public EditoraDtos(){

        }
    }
}