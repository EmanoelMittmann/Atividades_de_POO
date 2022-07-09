using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Entity;

namespace Biblioteca.WebApi.Domain.Dtos
{
    public class EditoraDtos
    {
        public int Id_Edit { get; set; }
        public string Nome {get; set;}
        public string Cidade{ get; set;}
    }
}