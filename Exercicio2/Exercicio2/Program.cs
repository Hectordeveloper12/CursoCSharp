using System;
using System.Globalization;

namespace Exercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== Cardápio =====");
            Console.WriteLine("1- Cachorro Quente R$4.00");
            Console.WriteLine("2- X-Salada        R$4.50");
            Console.WriteLine("3- X-Bacon         R$5.00");
            Console.WriteLine("4- Torrada Simples R$2.00");
            Console.WriteLine("5- Refrigerante    R$1.00");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Faça seu pedido: ");
            string[] pedido = Console.ReadLine().Split(" ");

            string produto = pedido[0];
            int qnt = int.Parse(pedido[1]);

            if (produto == "1")
            {
                double valor = 4.00;
                double soma = qnt * valor;
                Console.WriteLine(soma);
            }
            else if (produto == "2")
            {
                double valor = 4.50;
                double soma = qnt * valor;
                Console.WriteLine(soma);
            }
            else if (produto == "3")
            {
                double valor = 5.00;
                double soma = qnt * valor;
                Console.WriteLine(soma);
            }
            else if (produto == "4")
            {
                double valor = 2.00;
                double soma = qnt * valor;
                Console.WriteLine(soma);
            }
            else if (produto == "5")
            {
                double valor = 1.00;
                double soma = qnt * valor;
                Console.WriteLine(soma);
            }
            else
            {
                Console.WriteLine("Saindo...");
            }
        }
    }
}