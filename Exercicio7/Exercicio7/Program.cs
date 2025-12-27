using System;
using System.Globalization;

namespace Exercicio7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? : ");
            double dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? : ");
            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago em reais : " + Dolar.Conversor(dol, val).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}