using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using atividadeAS.models.repository;
using atividadeAS.models.Domain;
using atividadeAS.Dtos;
using atividadeAS.Viewsmodels;

namespace atividadeAS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneroControllers : ControllerBase
    {
        private readonly IGeneroRepository _repository;
        private readonly UnitOfwork _unitofwork;

        public GeneroControllers(IGeneroRepository repository, UnitOfwork unitOfwork)
        {
            this._repository = repository;
            this._unitofwork = unitOfwork;
        }

        [HttpGet]
        public async Task<List<Genero>> GetAll(){

            List<GeneroDtos> generoDtos = new List<GeneroDtos>();
            List<Genero> DbSetGenero = await _repository.GetAll();
            foreach(var procura in DbSetGenero)
            {
                var Dtos = new GeneroDtos()
                {
                    Id_Genero = procura.Id_Genero,
                    Nome = procura.nome
                };
                generoDtos.Add(Dtos);
            }
            return DbSetGenero;
        }

        [HttpPost]
        public async Task<string> createGenero([FromBody] GeneroViewModels entity)
        {
            var dados = new Genero
            {
                nome = entity.nome
            };
            _repository.Create(dados);
            await _unitofwork.CommitAsync();
            return "Genero Criado";
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromRoute] Genero genr)
        {
            _repository.Update(genr);
            await _unitofwork.CommitAsync();
            return (IActionResult)genr;
        }
        
    }
}