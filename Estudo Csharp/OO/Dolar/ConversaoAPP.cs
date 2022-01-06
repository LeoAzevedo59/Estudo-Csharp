using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Dolar
{
    class ConversaoAPP
    {
        static void X(String[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            Conversao.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            Conversao.CompraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + Conversao.Conv().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
