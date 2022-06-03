using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;
using Aula11_crudPeople.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula11_crudPeople.Controllers
{
    public class AddressControllers
    {
        [ApiController]
    [   Route("[controller]")]
    public class AddressController: ControllerBase
    {
        private IAddressesRepository repository;
        public AddressController(IAddressesRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet()]
        public IEnumerable<Address>Get()
        {
            return repository.GetAll();
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Address address)
        {
            address.Create(address);
            return Ok(new {
                message = "Endereço cadastrado com sucesso.",
                httpCode=202,
                objectCreated = address
            });
        }
    }
}
}