using System;

namespace listadeExercícios2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite os numeros da letra A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite os numeros da letra B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite os numeros da letra C");
            int C = Convert.ToInt32(Console.ReadLine());
            if (C > A + B)
            {
                Console.WriteLine("Está operação é menor que C");
            }
            else
            {
                Console.WriteLine("Está operação é maior que C");
            }
        }
    }
}
