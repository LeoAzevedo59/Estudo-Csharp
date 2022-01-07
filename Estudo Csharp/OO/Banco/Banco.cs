using System;
using System.Globalization;
namespace Estudo_Csharp.OO.Banco
{
    class Banco
    {
        private double _valor = 0;
        public int Conta { get; set; }
        public string Nome { get; set; }

        public double Validacao(char caracter)
        {

            if (caracter != 's')
                _valor = 0.00;
            else
                _valor = dinheiro();

            return _valor;
        }

        private double dinheiro()
        {
            Console.Write("Entre o valor de depósito inciial: ");
            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public double Deposito(double depoisto)
        {
            _valor += depoisto;
            return _valor;
        }

        public double Retirada(double deposito)
        {
            _valor -= deposito;
            return _valor;
        }

        public override string ToString()
        {
            return "Conta " +
                Conta +
                ", Titular: " +
                Nome +
                ", Saldo: $ " +
                _valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
