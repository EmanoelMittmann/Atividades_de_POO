using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.WebApi.Domain.Entity;
using Biblioteca.WebApi.Domain.Interfaces;
using Biblioteca.WebApi.Domain.Dtos;
using Biblioteca.WebApi.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.WebApi.Viewsmodels;

namespace Biblioteca.WebApi.Controllers
{
    public class LivroControllers
    {
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _repository;
        private readonly IUnitOfWork _unitofwork;

            public LivroController(ILivroRepository repository, IUnitOfWork unitofwork)
        {
            this._repository = repository;
            this._unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<List<Livro>> GetAll()
        {
            List<LivroDtos> LivroDto = new List<LivroDtos>();
            IList<Livro> Livros = await _repository.GetAllAsync();
            foreach(var procura in Livros)
            {
                var Dtos = new LivroDtos(){
                    Id_Livro = procura.Id,
                    Num_edit = procura.Num_edit,
                    Titulo = procura.Titulo,
                    Volume = procura.Volume
                };
                LivroDto.Add(Dtos);
            }
            return Livros.ToList();
        }


        [HttpPost]
        public async Task<string> createLivro([FromBody] LivroViewModels entity)
        {
            var dados = new Livro
            {
                Id = entity.Id_Livro,
                Num_edit = entity.Num_edit,
                Titulo = entity.Titulo,
                Volume = entity.Volume
            };
            _repository.Save(dados);
            await _unitofwork.CommitAsync();
            return "Autor enviado";
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Livro book)
        {
            _repository.Update(book);
            await _unitofwork.CommitAsync();
            return (IActionResult)book;
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
}