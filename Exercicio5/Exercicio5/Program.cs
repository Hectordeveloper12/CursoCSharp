using System;

namespace Exercicio5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();

            
            Console.WriteLine("Crie a pessoa 1:");
            x.A = Console.ReadLine();
            x.B = int.Parse(Console.ReadLine());
            Console.WriteLine("Crie a pessoa 2:");
            y.A = Console.ReadLine();
            y.B = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {x.A} \nIdade: {x.B}");
            Console.WriteLine($"Nome: {y.A} \nIdade: {y.B}");
            if (x.B > y.B)
            {
                Console.WriteLine($"Pessoa mais velha: {x.A}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {y.A}");
            }
            
        }
    }

}