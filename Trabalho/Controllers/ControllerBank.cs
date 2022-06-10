using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabalho.Models.Domain;
using Trabalho.Models.Dtos;
using Trabalho.Models.Repository;

namespace Trabalho.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerBank
    {
        
        private IRepositoryBank repositorio;

        public ControllerBank(IRepositoryBank repositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet]

        public async Task<List<BankDto>> GetAll()
        {
            List<BankDto> bankDtos = new List<BankDto>();
            List<Bank> DbSetBank = await repositorio.GetAll();
            foreach (var procura in DbSetBank)
            {
                BankDto Dto = new BankDto(procura);
                bankDtos.Add(Dto);
            }
            return bankDtos;
        }

        [HttpGet("{id:int}")]
        public async Task<BankDto> GetById(int id)
        {
            BankDto Dto = new BankDto(repositorio.GetById(id));
            return Dto;
        }

        [HttpPost]
        public async Task<string> createbank([FromBody] Bank card)
        {
            repositorio.create(card);
            return "cartao Inserido";
        }
        
        [HttpDelete("{id:int}")]
        public async Task<string> Delete(int id)
        {
            repositorio.Delete(id);
            return "cartao deletado";
        }
        [HttpPut]
        public async Task<string> Update([FromBody] Bank card)
        {
            repositorio.Update(card);
            return "cartao atualizado";
        }
    }
}