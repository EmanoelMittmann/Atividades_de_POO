using System;
using Aula03_encapsulamento.Domain;

namespace Aula03_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            WriteMsg("Criar o objeto mochila");
            
            Mochila mp = new Mochila(1,"qualquer coisa",100,20,"cinza");
            WriteMsg(mp.Descricao);

            WriteMsg($"Nome:,{mp.Descricao}");

            Item celular = new Item(100,"Nokia 3030");
            Item caneta = new Item(102,"caneta de quadro branco");

            mp.Itens.Add(celular);
            mp.Itens.Add(caneta);

            WriteMsg("Nome: " + mp.Descricao);
            WriteMsg("Itens");
            foreach (var item in mp.Itens)
            {
                WriteMsg(item.nome);
            }
                    }
        private static void WriteMsg(string msg){
            Console.WriteLine(msg);
        }
    }
}
