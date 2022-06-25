using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trabalho.Models.Domain
{   
    [Keyless]
    public class Bank
    {   
        public Bank(){}
        public Bank(int id_bank, string conta, string nome, double limite, double saldo)
        {
            Id_bank = id_bank;
            Conta = conta;
            Nome = nome;
            Limite = limite;
            Saldo = saldo;
        }

        public int Id_bank { get; set; }
        public string Conta  { get; set; }
        public string Nome { get; set; }
        public double Limite { get; set; }
        public double Saldo { get; set; }

    }
}