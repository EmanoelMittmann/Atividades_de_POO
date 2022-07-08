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
    public class EmprestimoControllers : ControllerBase
    {
        private readonly IEmprestimoRespository _repository;
        private readonly IUnitOfwork _unitofwork;

        public EmprestimoControllers(IEmprestimoRespository respository, IUnitOfwork unitofwork)
        {
            this._repository = respository;
            this._unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<List<EmprestimoDomain>> GetAll()
        {
            List<EmprestimoDtos> empresDto = new List<EmprestimoDtos>();
            List<EmprestimoDomain> DbSetEmprest = await _repository.GetAll();
            foreach(var procura in DbSetEmprest)
            {
                var Dtos = new EmprestimoDtos(){
                   LivroId = procura.Livro,
                   data_emprestimo = procura.data_emprestimo,
                   data_entrega = procura.data_entrega,
                   User_Cpf = procura.User,
                   prazo = procura.prazo
                };
                empresDto.Add(Dtos);
            }
            return DbSetEmprest;
        }

        [HttpPost]

        public async Task<string> emprestimoLivro([FromBody] EmprestimoViewModels entity)
        {
            var dados = new EmprestimoDomain
            {
                Livro = entity.Id_Livro,
                data_emprestimo = entity.data_emprestimo,
                data_entrega = entity.data_entrega,
                User = entity.User_Cpf,
                prazo = entity.prazo
            };
            _repository.Create(dados);
            await _unitofwork.CommitAsync();
            return "Emprestimo de livro criado";
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] EmprestimoDomain emprest)
        {
            _repository.Update(emprest);
            await _unitofwork.CommitAsync();
            return (IActionResult)emprest;
        }
        
    }
}