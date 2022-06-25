using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class EditoraDomain
    {
        public EditoraDomain(int id, string nome, string cidade)
        {
            this.id = id;
            this.nome = nome;
            this.cidade = cidade;
        }

        public int id { get; set; }
        public string nome {get; set;}
        public string cidade{ get; set;}
    }
}