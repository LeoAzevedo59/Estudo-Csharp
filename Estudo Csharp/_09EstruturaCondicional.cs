using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class _09EstruturaCondicional
    {
        public static void X(String[] args)
        {
            double PrimeiraNota, SegundaNota, Resultado;

            PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Resultado = PrimeiraNota + SegundaNota;

            Console.WriteLine("NOTA FINAL = " + Resultado.ToString("F1",CultureInfo.InvariantCulture));
            if (Resultado < 60.00)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
