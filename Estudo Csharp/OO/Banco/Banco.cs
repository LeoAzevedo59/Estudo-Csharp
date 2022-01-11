using System;
using System.Globalization;
namespace Estudo_Csharp.OO.Banco
{
    class Banco
    {
        private double _saldo = 0;
        public string Nome { get; set; }
        public int Conta { get; set; }

        public double Validacao(char caracter)
        {

            if (caracter != 's')
                _saldo = 0.00;
            else
            {
                Console.Write("Entre o valor de depósito inciial: ");
                _saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            return _saldo;
        }

        public double Deposito(double depoisto)
        {
            _saldo += depoisto;
            return _saldo;
        }

        public double Retirada(double deposito)
        {
            _saldo -= deposito + 5.0;
            return _saldo;
        }

        public override string ToString()
        {
            return "Conta " +
                Conta +
                ", Titular: " +
                Nome +
                ", Saldo: $ " +
                _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
