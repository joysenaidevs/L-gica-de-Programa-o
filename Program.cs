using System;

namespace Logica_de_progamação

{
    class Program
    {
        static void Main(string[] args)
        {
            //aqui vai o codigo

            //Console.WriteLine("Digite seu nome");
            //string nomeCompleto = Console.ReadLine();

            //Console.WriteLine("Seja bem vindo "+nomeCompleto);
            //fim

            int valorUm;
            int valorDois;

            //entrada de dados

            Console.WriteLine("Soma de dois números");
            Console.WriteLine("-------------------");
            Console.Write("Digite o primeiro valor:");
            valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo valor:");
            valorDois = int.Parse(Console.ReadLine());

            //Processamento
            int soma = valorUm + valorDois;

            //Exibir

            Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);
        }

            

    }
}
