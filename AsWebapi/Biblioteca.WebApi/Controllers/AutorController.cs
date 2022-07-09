using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Dtos;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.WebApi.Viewsmodels;

namespace Biblioteca.WebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _repository;
        private readonly IUnitOfWork _unitofwork;
        public AutorController(IAutorRepository repository, IUnitOfWork unitofwork)
        {
            this._repository = repository;
            this._unitofwork = unitofwork;
        }

        [HttpGet("v1/Autores")]
        public async Task<List<Autor>> GetAll()
        {
            List<AutorDtos> autorDto = new List<AutorDtos>();
            IList<Autor> Autores = await _repository.GetAllAsync();
            foreach(var procura in Autores)
            {
                var Dtos = new AutorDtos(){
                    Id_Autor = procura.Id,
                    nome = procura.Nome
                };
                autorDto.Add(Dtos);
            }
            return Autores.ToList();
        }


        [HttpPost("Autor")]
        public async Task<IActionResult> PostAsync([FromBody] AutorViewModels entity)
        {
            var dados = new Autor
            {
                Nome = entity.Nome
            };
            _repository.Save(dados);
            await _unitofwork.CommitAsync();
            return Ok(dados);
        }

        [HttpPatch("v1/Autor/{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Autor autor)
        {
            _repository.Update(autor);
            await _unitofwork.CommitAsync();
            return (IActionResult)autor;
        }

        [HttpDelete("v1/Autor/{id:int}")]
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