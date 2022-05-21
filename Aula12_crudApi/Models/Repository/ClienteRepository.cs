using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_crudApi.Models.Domains;

namespace Aula12_crudApi.Models.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private Datacontext context;
        public ClienteRepository(Datacontext context){
            this.context = context;
        }

        public void Create(DomainCliente person)
        {
            context.Add(person);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<DomainCliente> GetAll()
        {
            return context.Cliente.ToList();
        }

        public DomainCliente GetById(int Id)
        {
            return context.Cliente.SingleOrDefault(i =>i.Id == Id);
        }

        public void Update(DomainCliente client)
        {
            throw new NotImplementedException();
        }

        List<DomainCliente> IClienteRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}