using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o seu peso");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a sua altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (altura * altura);
            if (imc <= 18.5)
            {
                Console.WriteLine($"O seu imc está em {imc}, de acordo com o resultado, você está abaixo do peso ideal ");
            }
            else if (imc > 18.5 || imc <= 25) 
            {
                Console.WriteLine($"O seu imc está em {imc}, de acordo com o resultado, você está no peso ideal ");
            }
            else if (imc > 25 || imc <= 30)
            {
                Console.WriteLine($"O seu imc está em {imc}, de acordo com o resultado, você está acima do peso ideal ");
            }
            else if (imc > 30)
            {
                Console.WriteLine($"O seu imc está em {imc}, de acordo com o resultado, você está em estado de obesidade");
            }
        }
    }
}
