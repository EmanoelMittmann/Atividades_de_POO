using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadeAS.models.Domain
{
    public class LivroDomain
    {
        public LivroDomain(int id_Livro, string titulo, int num_edit, int volume, int genero_id, int editora_id)
        {
            Id_Livro = id_Livro;
            this.Titulo = titulo;
            Num_edit = num_edit;
            Volume = volume;
        }

        public int Id_Livro { get; set; }
        public string Titulo { get; set; }
        public int Num_edit { get; set; }
        public int Volume { get; set; }
        public EditoraDomain Id_Edit {get; set;}
       
}
}