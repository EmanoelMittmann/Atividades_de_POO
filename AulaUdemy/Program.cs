using System;
using System.Globalization;

namespace AulaUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];


            Console.WriteLine("Voce digitou ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);

        }
    }
}
