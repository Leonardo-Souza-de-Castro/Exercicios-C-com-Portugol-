using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
          string nome;
          int idade;

          
          Console.WriteLine("Ola!, Insira seu nome");
          nome = Console.ReadLine();
          Console.WriteLine("Olá " + nome + " qual a sua idade?");
          idade = int.Parse(Console.ReadLine());

          if((idade >= 5) && (idade <= 7)){
                Console.WriteLine("Você pertence a categoria Infantil A");
          }

           if ((idade >= 8) && (idade <= 10))
           {
                Console.WriteLine("Você pertence a categoria Infantil B");
           }

           if ((idade >= 11) && (idade <= 13))
           {
               Console.WriteLine("Você pertence a categoria Juvenil A");
           }

           if ((idade >= 14) && (idade <=17))
           {
               Console.WriteLine("Você pertence a turma Juvenil B");
           }

           if (idade >= 18)
           {
               Console.WriteLine("Você pertence a turma Sênior");
           }
        }
    }
}
