using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class _05EntradasDeDados03
    {
        public static void X(String [] args)
        {
            string nome, nome2;
            int numeroQuartos, idade;
            double precoProduto, altura;
            
            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na casa?");
            numeroQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto:");
            precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');

            nome2 = vet[0];
            idade = int.Parse(vet[1]);
            altura = double.Parse(vet[2]);

            Console.WriteLine(nome + "\n" + numeroQuartos + "\n" + precoProduto.ToString("F2", CultureInfo.InvariantCulture) + "\n" + nome2 + "\n" + idade + "\n" + altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
