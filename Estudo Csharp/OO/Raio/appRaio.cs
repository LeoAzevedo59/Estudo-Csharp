using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Raio
{
    class appRaio
    {
        static void X(String[] args)
        {
            double pi = 3.14;

            Raio raio = new Raio();

            Console.Write("Entre o valor de raio: ");
            raio.ValorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferência: " + raio.Circunferencia(pi).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + raio.Volume(pi).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI:" + pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }

    class Raio
    {
        public double ValorRaio;

        public double Volume(double pi)
        {
            return (4 * pi * Math.Pow(ValorRaio, 3)) / 3.0;
        }

        public double Circunferencia(double pi)
        {
            return 2 * pi * ValorRaio;
        }

    }
}
