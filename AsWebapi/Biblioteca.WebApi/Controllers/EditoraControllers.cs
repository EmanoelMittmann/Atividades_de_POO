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
    public class EditoraControllers : ControllerBase
    {
        private readonly IEditoraRepository _repository;
        private readonly IUnitOfWork _unitofwork;

        public EditoraControllers(IEditoraRepository repository, IUnitOfWork unitOfwork)
        {
            this._repository = repository;
            this._unitofwork = unitOfwork;
        }

        [HttpGet]

        public async Task<List<Editora>> GetAll()
        {
            List<EditoraDtos> editoraDtos = new List<EditoraDtos>();
            IList<Editora> Editoras = await _repository.GetAllAsync();
            foreach(var procura in Editoras)
            {
                var Dtos = new EditoraDtos(){
                    Id_Edit = procura.Id,
                    Nome = procura.Nome,
                    Cidade = procura.Cidade
                };
                editoraDtos.Add(Dtos);
            }
            return Editoras.ToList();
        }

        [HttpPost]
        public async Task<string> createEdit([FromBody] EditoraViewModels edit)
        {
            var dados = new Editora
            {
                Nome = edit.nome,
                Cidade = edit.cidade
            };
            _repository.Save(dados);
            await _unitofwork.CommitAsync();
            return "Editora adicionada";

        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id,[FromBody] Editora edit)
        {
            _repository.Update(edit);
            await _unitofwork.CommitAsync();
            return (IActionResult)edit;
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