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

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Person person)
        {
            repository.Create(person);
            return Ok(person);
        }
        [HttpPut]
        public IActionResult UpdateClient([FromBody] Person person)
        {

            repository.Create(person);
            return Ok(new{
                message = "Person Updated.",
                errorCode = 202,
                objCreated = person
            });
        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(new{
                message = "Person deleted.",
                errorCode = 202
            });
        }
    }
}