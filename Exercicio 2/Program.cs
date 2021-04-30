using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano_de_nascimento;
            int ano_atual;
            int idade;
            int semanas;

            Console.WriteLine("Insira seu ano de nascimento");
            ano_de_nascimento = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira seu ano atual");
            ano_atual = int.Parse(Console.ReadLine());

            idade = ano_atual - ano_de_nascimento;
            Console.WriteLine("Sua idade é: " + idade);

            semanas = idade * 48;
            Console.WriteLine("Sua idade em semanas é: " + semanas);

            Console.WriteLine("Fim do Programa!!");
        }
    }
}
