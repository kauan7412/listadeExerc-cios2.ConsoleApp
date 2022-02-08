using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o numero");
            double numero = Convert.ToDouble(Console.ReadLine());
            double resto = numero % 2;
            if (resto == 0) 
            { 
            Console.WriteLine("O seu numero é par");
            }
            else 
            {
                Console.WriteLine("O seu numero é ímpar");
            };
        }
    }
}
