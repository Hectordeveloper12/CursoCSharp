using System;
using System.Globalization;

namespace Exercicio8
{
    public class Program
    {
        public static void Main()
        {


            Console.Write("Entre o número da conta: ");
            int idConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito incial (s/n): ");
            string escolha = Console.ReadLine();

            Banco p;

            if (escolha == "s")
            {
                Console.Write("Entre o valor de depósito inical: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new Banco(idConta, nome, depositoInicial);
            }else
            {
                p = new Banco(idConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double depositando = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Depositar(depositando);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre um valor de saque: ");
            double sacando = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Sacar(sacando);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);
        }
    }
}