using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro valor.");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo valor.");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o terceiro valor.");
            int C = Convert.ToInt32(Console.ReadLine());
            if (A > B && A > C && B > C)
            {
                Console.WriteLine($"primeiro valor {A}, segundo valor {B}, terceiro valor {C}");
            }
            else if (B > A && B > C && A > C)
            {
                Console.WriteLine($"primeiro valor {B}, segundo valor {A}, terceiro valor {C}");                   
            }
            else if (C > A && C > B && A > B)
            {
                Console.WriteLine($"primeiro valor {C}, segundo valor {A}, terceiro valor {B}");
            }
            else if (C > A && C > B && B > A)
            {
                Console.WriteLine($"primeiro valor {C}, segundo valor {B}, terceiro valor {A}");
            }
            else if (B > A && B > C && C > A)
            {
                Console.WriteLine($"primeiro valor {B}, segundo valor {C}, terceiro valor {A}");
            }
            else if (A > C && A > B && C > B)
            {
                Console.WriteLine($"primeiro valor {A}, segundo valor {C}, terceiro valor {B}");
            }
        }
    }
}
