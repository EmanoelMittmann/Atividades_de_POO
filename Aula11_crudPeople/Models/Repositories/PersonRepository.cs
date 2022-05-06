using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;

namespace Aula11_crudPeople.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private DataContext context;
        public PersonRepository(DataContext context){
            this.context = context;
        }
        public void Create(Person person)
        {
            context.Add(person);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
           return context.People.ToList();
        }

        public Person GetById(int Id)
        {
            return context.People.SingleOrDefault(i=>i.Id == Id);
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}