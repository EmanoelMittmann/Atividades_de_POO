using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_crudApi.Models.Domains;
using Aula12_crudApi.Models.Repository;
using Microsoft.AspNetCore.Mvc;
namespace Aula12_crudApi.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ControllersClient:ControllerBase
    {
        private IClienteRepository repositorio;

        public ControllersClient(IClienteRepository repositorio)
        {
            this.repositorio = repositorio;
        }
        [HttpGet()]

        public IEnumerable<DomainCliente>Get()
        {
            return repositorio.GetAll();
        }
        [HttpPost()]
        public IActionResult Post([FromBody] DomainCliente cliente)
        {
            repositorio.Create(cliente);
            return Ok(cliente);   
        }
    }
}