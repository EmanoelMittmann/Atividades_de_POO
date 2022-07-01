using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.Dtos;
using atividadeAS.models.Domain;
using atividadeAS.models.repository;
using atividadeAS.Viewsmodels;
using Microsoft.AspNetCore.Mvc;

namespace atividadeAS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControllers : ControllerBase
    {
        private readonly IUsuarioRepository _repository;
        private readonly IUnitOfwork _unitofwork;

        public UsuarioControllers(IUsuarioRepository repository, IUnitOfwork unitOfwork)
        {
            this._repository = repository;
            this._unitofwork = unitOfwork;
        }

        [HttpGet]
        
        public async Task<List<Usuario>> GetAll()
        {
            List<UsuarioDtos> userDto = new List<UsuarioDtos>();
            List<Usuario> DbSetUser = await _repository.GetAll();
            foreach(var procura in DbSetUser)
            {
                var Dtos = new UsuarioDtos(){
                    Id_user = procura.Id_user,
                    CPF = procura.CPF,
                    Nome = procura.Nome,
                    Endereco = procura.Endereco,
                    Telefone = procura.Telefone,
                    Email = procura.Email
                };
                userDto.Add(Dtos);
            }
            return DbSetUser;
        }

        [HttpPost]
        public async Task<string> createUser([FromBody] UserViewModels entity)
        {
            var dados = new Usuario()
            {   
                Nome = entity.Nome,
                CPF = entity.CPF,
                Endereco = entity.Endereco,
                Telefone = entity.Telefone,
                Email = entity.Email
            };
            _repository.Create(dados);
            await _unitofwork.CommitAsync();
            return "Usuario criado";
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Usuario user)
        {
            _repository.Update(user);
            await _unitofwork.CommitAsync();
            return (IActionResult)user;

        }

        
    }
}