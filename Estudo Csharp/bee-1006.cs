using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1006
    {
        public static void X(String[] args)
        {
            double A, B, C, Media;
            int PesoA, PesoB, PesoC;

            PesoA = 2;
            PesoB = 3;
            PesoC = 5;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Media = (((A * PesoA) + (B * PesoB) + (C * PesoC)) / (PesoA + PesoB + PesoC));

            Console.WriteLine("MEDIA = " + Media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
