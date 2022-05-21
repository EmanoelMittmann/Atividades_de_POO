using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;
using Microsoft.EntityFrameworkCore;

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
            person.City = context.Cities.SingleOrDefault(x=>x.id == person.City.Id);
            context.Add(person);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
           return context.People.Include(c=>c.City).ToList();
        }

        public Person GetById(int Id)
        {
            return context.People.Include(c=>c.City).SingleOrDefault(i=>i.Id == Id);
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
