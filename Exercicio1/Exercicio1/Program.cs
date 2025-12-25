using System;
using System.Globalization;

namespace Exercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual é o primeiro produto?");
            String[] valores1 = Console.ReadLine().Split(" ");
            int cod1 = int.Parse(valores1[0]);
            int qnt1 = int.Parse(valores1[1]);
            double valor1 = double.Parse(valores1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Qual é o segundo produto?");
            String[] valores2 = Console.ReadLine().Split(" ");
            int cod2 = int.Parse(valores2[0]);
            int qnt2 = int.Parse(valores2[1]);
            double valor2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

            double soma = (double) valor1 * qnt1 + valor2 * qnt2;


            Console.WriteLine($"Valor a pagar é {soma:F2}");
        }
    }
}