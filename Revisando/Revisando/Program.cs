using System;

namespace Revisando;

public class Program
{
    public static void Main()
    {
        Console.Write("Deseja criar quantas pessoas? ");
        int n = int.Parse(Console.ReadLine());
        Pessoa[] pessoas = new Pessoa[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Qual vai ser o nome da pessoa? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual vai ser a idade da pessoa? ");
            int idade = int.Parse(Console.ReadLine());

            pessoas[i] = new Pessoa(nome, idade);
        }

        int qntdPessoa = pessoas.Length;

        for (int i = 0; i < qntdPessoa; i++)
        {
            Console.WriteLine($"Nome: {pessoas[i].Nome}\nIdade: {pessoas[i].Idade}");
        }
    }
}