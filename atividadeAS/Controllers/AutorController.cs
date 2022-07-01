using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividadeAS.models.Domain;
using atividadeAS.models.repository;
using Microsoft.AspNetCore.Mvc;
using atividadeAS.Dtos;
using atividadeAS.Viewsmodels;

namespace atividadeAS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _repository;
        private readonly IUnitOfwork _unitofwork;
        public AutorController(IAutorRepository repository, IUnitOfwork unitofwork)
        {
            this._repository = repository;
            this._unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<List<Autor>> GetAll()
        {
            List<AutorDtos> autorDto = new List<AutorDtos>();
            List<Autor> DbSetAutor = await _repository.GetAll();
            foreach(var procura in DbSetAutor)
            {
                var Dtos = new AutorDtos(){
                    Id_Autor = procura.Id_Autor,
                    nome = procura.Nome
                };
                autorDto.Add(Dtos);
            }
            return DbSetAutor;
        }


        [HttpPost]
        public async Task<string> createAutor([FromBody] AutorViewModels entity)
        {
            var dados = new Autor
            {
                Nome = entity.Nome
            };
            _repository.Create(dados);
            await _unitofwork.CommitAsync();
            return "Autor enviado";
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Autor autor)
        {
            _repository.Update(autor);
            await _unitofwork.CommitAsync();
            return (IActionResult)autor;
        }
    }
}