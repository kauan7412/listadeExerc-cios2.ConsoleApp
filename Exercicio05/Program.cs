using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro valor.");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo valor.");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A == B) 
            {
                int t1 = A + B;
                Console.WriteLine($"{t1}");
            }
            else 
            { 
                int t2 = A * B;
                Console.WriteLine($"{t2}");
            }
        }
    }
}
