using System;
using Aula05_Execicios.Controllers;
using Aula05_Execicios.Domain;

namespace Aula05_Execicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ContatoControllers agenda = new ContatoControllers();
            agenda.Menu();
        }
    }
}