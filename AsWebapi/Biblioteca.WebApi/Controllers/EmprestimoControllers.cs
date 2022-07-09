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
    public class EmprestimoControllers : ControllerBase
    {
        private readonly IEmprestimoRepository _repository;
        private readonly IUnitOfWork _unitofwork;

        public EmprestimoControllers(IEmprestimoRepository respository, IUnitOfWork unitofwork)
        {
            this._repository = respository;
            this._unitofwork = unitofwork;
        }

        [HttpGet]
        public async Task<List<Emprestimo>> GetAll()
        {
            List<EmprestimoDtos> empresDto = new List<EmprestimoDtos>();
            IList<Emprestimo> emprestimos = await _repository.GetAllAsync();
            foreach(var procura in emprestimos)
            {
                var Dtos = new EmprestimoDtos(){
                   Id_Livro = procura.Livro,
                   data_emprestimo = procura.DataEmprestimo,
                   data_entrega = procura.DataDevolucao,
                };
                empresDto.Add(Dtos);
            }
            return emprestimos.ToList();
        }

        [HttpPost]

        public async Task<string> emprestimoLivro([FromBody] EmprestimoViewModels entity)
        {
            var dados = new Emprestimo
            {
                Livro = entity.Id_Livro,
                DataEmprestimo = entity.data_emprestimo,
                DataDevolucao = entity.data_entrega,
                Cliente = entity.User_Cpf
                
            };
            _repository.Save(dados);
            await _unitofwork.CommitAsync();
            return "Emprestimo de livro criado";
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Emprestimo emprest)
        {
            _repository.Update(emprest);
            await _unitofwork.CommitAsync();
            return (IActionResult)emprest;
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