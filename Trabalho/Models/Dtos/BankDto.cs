using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho.Models.Domain;

namespace Trabalho.Models.Dtos
{
    public class BankDto
    {
        public int Id_bank { get; set; }
        public string Conta  { get; set; }
        public string Nome { get; set; }
        public double Limite { get; set; }
        public double Saldo { get; set; }

        public BankDto(Bank entity)
        {  
            Id_bank = entity.Id_bank;
            Conta = entity.Conta;
            Nome = entity.Nome;
            Limite = entity.Limite;
            Saldo = entity.Saldo;
        }
        public BankDto()
        {

        }
    }
}