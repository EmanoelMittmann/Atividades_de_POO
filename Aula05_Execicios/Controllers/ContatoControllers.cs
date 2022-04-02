using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula05_Execicios.Services;

namespace Aula05_Execicios.Controllers
{
    public class ContatoControllers
    {
        ContatoService controle = new ContatoService();

        public void Menu()
        {
            string operador = string.Empty;

            while(operador != "8")
            {
                Console.WriteLine("Digite 0 para parar");
                Console.WriteLine("Digite 1 para add um novo contato");
                Console.WriteLine("Digite 2 para mostrar a lista");

                operador = Console.ReadLine();
                switch(operador)
                {
                    case "0":
                        Environment.Exit(0);
                    break;

                    case "1":
                        Console.WriteLine("Digite o nome do contato");
                        string nome = Console.ReadLine().Trim();

                        Console.WriteLine("Digite o telefone do contato");
                        string telefone = Console.ReadLine().Trim();

                        string retorno = controle.CriarContato(nome , telefone);

                        Console.WriteLine(retorno);
                    break;

                    case "2":
                        var retorno2 = controle.ListarContatos();
                        Console.WriteLine(retorno2);
                    break;

                    default:
                        Console.WriteLine("opcao invalida");
                        Menu();
                    break;
                }
            }
        }
    }
}