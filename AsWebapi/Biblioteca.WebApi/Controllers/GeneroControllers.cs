using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Biblioteca.WebApi.Data;
using Biblioteca.WebApi.Domain.Dtos;
using Biblioteca.WebApi.Viewsmodels;

namespace Biblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeneroControllers : ControllerBase
    {
        private readonly IGeneroRepository _repository;
        private readonly IUnitOfWork _unitofwork;

        public GeneroControllers(IGeneroRepository repository, IUnitOfWork unitOfwork)
        {
            this._repository = repository;
            this._unitofwork = unitOfwork;
        }

        [HttpGet]
        public async Task<List<Genero>> GetAll(){

            List<GeneroDtos> generoDtos = new List<GeneroDtos>();
            IList<Genero> generos = await _repository.GetAllAsync();
            foreach(var procura in generos)
            {
                var Dtos = new GeneroDtos()
                {
                    Id_Genero = procura.Id,
                    Nome = procura.Nome
                };
                generoDtos.Add(Dtos);
            }
            return generos.ToList();
        }

        [HttpPost]
        public async Task<string> createGenero([FromBody] GeneroViewModels entity)
        {
            var dados = new Genero
            {
                Nome = entity.nome
            };
            _repository.Save(dados);
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