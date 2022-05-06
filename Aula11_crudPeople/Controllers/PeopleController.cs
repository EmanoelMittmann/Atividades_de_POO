using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;
using Aula11_crudPeople.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula11_crudPeople.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController: ControllerBase
    {
        private IPersonRepository repository;
        public PeopleController(IPersonRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet()]
        public IEnumerable<Person>Get()
        {
            return repository.GetAll();
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Person person)
        {
            repository.Create(person);
            return Ok(person);
        }
    }
}