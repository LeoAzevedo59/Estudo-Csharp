using System;
using System.Globalization;
namespace Estudo_Csharp.OO.Banco
{
    class Banco
    {
        public int Conta { get; set; }
        public string Nome { get; set; }
        public char Caracter { get; set; }
        public double Deposito { get; set; }
        public double Dinheiro { get; set; }

        public double Validacao()
        {
            if (Caracter != 's')
                Dinheiro = 0.00;
            else
            {
                Console.Write("Entre o valor de depósito inciial: ");
                Dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            return Dinheiro;
        }

        public double Dep()
        {
            Dinheiro = Deposito + Dinheiro;
            return Dinheiro;
        }

        public double Retirada()
        {
            Dinheiro = Dinheiro - Deposito;
            return Dinheiro;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $ " + Dinheiro.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
