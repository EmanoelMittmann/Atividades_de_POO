using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;

namespace atividadeAS.Dtos
{
    public class LivroDtos
    {
        public int Id_Livro { get; set; }
        public string Titulo { get; set; }
        public int Num_edit { get; set; }
        public int Volume { get; set; }

        public LivroDtos(Livro entity)
        {
            Id_Livro = entity.Id_Livro;
            Titulo = entity.Titulo;
            Num_edit = entity.Num_edit;
            Volume = entity.Volume;
        }
        public LivroDtos(){
            
        }
    }
}