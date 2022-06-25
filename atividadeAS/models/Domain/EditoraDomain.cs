using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class EditoraDomain
    {
        public EditoraDomain(int id_edit, string nome, string cidade)
        {
            this.Id_Edit = id_edit;
            this.nome = nome;
            this.cidade = cidade;
        }

        public int Id_Edit { get; set; }
        public string nome {get; set;}
        public string cidade{ get; set;}
    }
}