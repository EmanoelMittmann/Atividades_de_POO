using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Entity;

namespace Biblioteca.WebApi.Domain.Dtos
{
    public class AutorDtos
    {
        public int Id_Autor{ get; set; }
        public string nome{ get; set; }
    }
}