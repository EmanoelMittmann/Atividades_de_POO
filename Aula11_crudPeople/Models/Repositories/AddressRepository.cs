using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace Aula11_crudPeople.Models.Repositories
{
    public class AddressRepository : IAddressesRepository
    {
        private DataContext context;

        public AddressRepository(DataContext context){
            this.context = context;
        }
        public void Create(Address entity)
        {
            entity.person =context.People
                .SingleOrDefault(x=>x.Id == entity.person.Id);
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Address> IAddressesRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
    
}