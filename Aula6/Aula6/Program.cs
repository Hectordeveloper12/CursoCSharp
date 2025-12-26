using System;

namespace Aula6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}