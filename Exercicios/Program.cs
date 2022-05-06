using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int a,b,c,d;
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            if(b > c && d > a){
                if((c+d) > (a+b)){
                    if(c / 2 > 0 || d / 2 > 0 && a / 2 == 0){
                            Console.WriteLine("Valores Aceitos");
                    }
                }
            }
            else{
                Console.WriteLine("valores não aceitos");
            }

        }
    }
}
