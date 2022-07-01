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
    public class LivroControllers
    {
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly ILivroRepository _repository;
        private readonly IUnitOfwork _unitofwork;
        public AutorController(ILivroRepository repository, IUnitOfwork unitofwork)
        {
            this._repository = repository;
            this._unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<List<Livro>> GetAll()
        {
            List<LivroDtos> LivroDto = new List<LivroDtos>();
            List<Livro> DbSetLivro = await _repository.GetAll();
            foreach(var procura in DbSetLivro)
            {
                var Dtos = new LivroDtos(){
                    Id_Livro = procura.Id_Livro,
                    Num_edit = procura.Num_edit,
                    Titulo = procura.Titulo,
                    Volume = procura.Volume
                };
                LivroDto.Add(Dtos);
            }
            return DbSetLivro;
        }


        [HttpPost]
        public async Task<string> createAutor([FromBody] LivroViewModels entity)
        {
            var dados = new Livro
            {
                Id_Livro = entity.Id_Livro,
                Num_edit = entity.Num_edit,
                Titulo = entity.Titulo,
                Volume = entity.Volume
            };
            _repository.Create(dados);
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
    }
    }
}