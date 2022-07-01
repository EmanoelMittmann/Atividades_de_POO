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
    public class EditoraControllers : ControllerBase
    {
        private readonly IEditoraRepository _repository;
        private readonly IUnitOfwork _unitofwork;

        public EditoraControllers(IEditoraRepository repository, IUnitOfwork unitOfwork)
        {
            this._repository = repository;
            this._unitofwork = unitOfwork;
        }

        [HttpGet]

        public async Task<List<EditoraDomain>> GetAll()
        {
            List<EditoraDtos> editoraDtos = new List<EditoraDtos>();
            List<EditoraDomain> DbSetEditora = await _repository.GetAll();
            foreach(var procura in DbSetEditora)
            {
                var Dtos = new EditoraDtos(){
                    Id_Edit = procura.Id_Edit,
                    Nome = procura.nome,
                    Cidade = procura.cidade
                };
                editoraDtos.Add(Dtos);
            }
            return DbSetEditora;
        }

        [HttpPost]
        public async Task<string> createEdit([FromBody] EditoraViewModels edit)
        {
            var dados = new EditoraDomain
            {
                nome = edit.nome,
                cidade = edit.cidade
            };
            _repository.Create(dados);
            await _unitofwork.CommitAsync();
            return "Editora adicionada";

        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id,[FromBody] EditoraDomain edit)
        {
            _repository.Update(edit);
            await _unitofwork.CommitAsync();
            return (IActionResult)edit;
        }
    }
}