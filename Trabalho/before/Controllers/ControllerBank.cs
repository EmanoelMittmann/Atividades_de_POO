using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Trabalho.Models.Domain;
using Trabalho.Models.Dtos;
using Trabalho.Models.Repository;

namespace Trabalho.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerBank
    {
        
        private readonly IRepositoryBank repositorio;
        private readonly IUnitOfWork _unitOfWork;

        public ControllerBank(IRepositoryBank repositorio, IUnitOfWork unitOfWork)
        {
            this.repositorio = repositorio;
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]

        public async Task<List<Bank>> GetAll()
        {
            List<BankDto> bankDtos = new List<BankDto>();
            List<Bank> DbSetBank = await repositorio.GetAll();
            foreach (var procura in DbSetBank)
            {
                var bankdto = new BankDto(){
                    Id_bank = procura.Id_bank,
                    Conta =procura.Conta,
                    Nome = procura.Nome,
                    Limite = procura.Limite,
                    Saldo = procura.Saldo
                };
                bankDtos.Add(bankdto);
            }
            return DbSetBank;
        }

        [HttpGet("{id:int}")]
        public async Task<BankDto> GetById(int id)
        {
            var bank = await repositorio.GetByIdAsync(id);
            var dto = new BankDto(){
                Id_bank = bank.Id_bank,
                Conta = bank.Conta,
                Nome = bank.Nome,
                Limite = bank.Limite,
                Saldo = bank.Saldo
            };
            return dto;
        }

        [HttpPost]
        public async Task<string> createbank([FromBody] Bank card)
        {
            var dados = new Bank()
            {
                Id_bank = card.Id_bank,
                Conta = card.Conta,
                Nome = card.Nome,
                Limite = card.Limite,
                Saldo = card.Saldo
            };
            
            repositorio.Create(card);
            await _unitOfWork.CommitAsync();
            return "cartao Inserido";
        }
        
        [HttpDelete("{id:int}")]
        public async Task<string> Delete(int id)
        {
            repositorio.Delete(id);
            await _unitOfWork.CommitAsync();
            return "cartao deletado";

        }
        
        [HttpPatch("{id}")]
       public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Bank card)
        {

            repositorio.Update(card);
            await _unitOfWork.CommitAsync();
            return (IActionResult)card;
        
        }
    }
}