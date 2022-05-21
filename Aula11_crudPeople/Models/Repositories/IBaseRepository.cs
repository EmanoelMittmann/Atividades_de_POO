using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula11_crudPeople.Models.Repositories
{
    public interface IBaseRepository<Entity>
       where Entity : class
    {
        Entity GetById(int id);
        List<PersonRepository> GetAll();
        void Create(PersonRepository person);
        void Update(PersonRepository person);
        void Delete(int id);
    }
}