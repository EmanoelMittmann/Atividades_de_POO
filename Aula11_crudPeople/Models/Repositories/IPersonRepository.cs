using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;

namespace Aula11_crudPeople.Models.Repositories
{
    public interface IPersonRepository:IBaseRepository<Person>
    {
        
    }
}