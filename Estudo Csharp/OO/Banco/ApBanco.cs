using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Banco
{
    class ApBanco
    {
        static void Main(String[] args)
        {
            Banco banco = new Banco();

            Console.Write("Entre o número da conta: ");
            banco.Conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            banco.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            banco.Validacao(char.Parse(Console.ReadLine().ToLower()));


            Console.WriteLine("\n" + "Dados da conta:" + "\n" + banco + "\n");

            Console.Write("Entre um valor para depósito: ");
            banco.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\n" + "Dados da conta atualizados:" + "\n" + banco + "\n");

            Console.Write("Entre um valor para saque: ");
            banco.Retirada(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("\n" + "Dados da conta atualizados:" + "\n" + banco + "\n");

            


        }
    }
}
