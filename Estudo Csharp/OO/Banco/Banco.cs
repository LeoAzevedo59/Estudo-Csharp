using System;
using System.Globalization;
namespace Estudo_Csharp.OO.Banco
{
    class Banco
    {
        private double valor = 0;
        public int Conta { get; set; }
        public string Nome { get; set; }

        public double Validacao(char Caracter)
        {

            if (Caracter != 's')
                valor = 0.00;
            else
                valor = dinheiro();

            return valor;
        }

        public double dinheiro()
        {
            Console.Write("Entre o valor de depósito inciial: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
     
        public double Deposito(double depoisto)
        {
            valor += depoisto;
            return valor;
        }

        public double Retirada(double deposito)
        {
            valor -= deposito;
            return valor;
        }

        public override string ToString()
        {
            return "Conta " +
                Conta +
                ", Titular: " +
                Nome +
                ", Saldo: $ " +
                valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
