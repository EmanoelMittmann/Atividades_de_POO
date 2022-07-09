using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Dtos;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Data.Context;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.WebApi.Viewsmodels;

namespace Biblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteControllers : ControllerBase
    {
        private readonly IClienteRepository _repository;
        private readonly IUnitOfWork _unitofwork;

        public ClienteControllers(IClienteRepository repository, IUnitOfWork unitOfwork)
        {
            this._repository = repository;
            this._unitofwork = unitOfwork;
        }

        [HttpGet]
        
        public async Task<List<Cliente>> GetAllAsync()
        {
            List<ClienteDtos> userDto = new List<ClienteDtos>();
            IList<Cliente> Clientes = await _repository.GetAllAsync();
            foreach(var procura in Clientes)
            {
                var Dtos = new ClienteDtos(){
                    Id_user = procura.Id,
                    CPF = procura.CPF,
                    Nome = procura.Nome,
                    Endereco = procura.Endereco,
                    Telefone = procura.Telefone,
                    Email = procura.Email
                };
                userDto.Add(Dtos);
            }
            return Clientes.ToList();
        }

        [HttpPost]
        public async Task<string> createUser([FromBody] ClienteViewModels entity)
        {
            var dados = new Cliente()
            {   
                Nome = entity.Nome,
                CPF = entity.CPF,
                Endereco = entity.Endereco,
                Telefone = entity.Telefone,
                Email = entity.Email
            };
            _repository.Save(dados);
            await _unitofwork.CommitAsync();
            return "Usuario criado";
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Cliente user)
        {
            _repository.Update(user);
            await _unitofwork.CommitAsync();
            return (IActionResult)user;

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]int id)
        {
            var Deleted = _repository.Delete(id);
            await _unitofwork.CommitAsync();

            if(Deleted == false)
            {
                return NotFound();
            }
            else
            {
                return Ok(id);
            }
        }

        
    }
}