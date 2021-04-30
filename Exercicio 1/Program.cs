using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            double meses;
            double dias;
            double horas;
            double minutos;

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            meses = idade * 12;
            dias = idade * 365;
            horas = dias * 24;
            minutos = horas * 60;

            Console.WriteLine("Sua idade em meses é: " + meses);
            Console.WriteLine("Sua idade em dias é: " + dias);
            Console.WriteLine("Sua idade em horas é: " + horas);
            Console.WriteLine("Sua idade em minutos é: " + minutos);

            Console.WriteLine("Fim do Programa");
        }
    }
}
