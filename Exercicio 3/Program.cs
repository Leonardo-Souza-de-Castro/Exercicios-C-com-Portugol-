using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double salario_novo;

            Console.WriteLine("Favor digitar o valor a ser reajustado");
            salario = double.Parse(Console.ReadLine());

            if(salario < 500){
            salario_novo = (salario * 30) / 100;
            salario = salario + salario_novo;

            Console.WriteLine("O seu novo salario é de: " + salario);
            }else{
                Console.WriteLine("Você não tem reajuste");
            }

            Console.WriteLine("Fim do Programa!!");
        }
    }
}
