using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_crudApi.Models.Domains;

namespace Aula12_crudApi.Models.Repository
{
    public interface IClienteRepository
    {
        DomainCliente GetById(int Id);

        List<DomainCliente>GetAll();

        void Create(DomainCliente client);

        void Update(DomainCliente client);

        void Delete(int id);
        

    }
}