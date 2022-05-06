using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;

namespace Aula11_crudPeople.Models.Repositories
{
    public interface IPersonRepository
    {
        Person GetById(int Id);
        List<Person>GetAll();

        void Create(Person person);
        void Update(Person person);
        void Delete(int id);
        
    }
}