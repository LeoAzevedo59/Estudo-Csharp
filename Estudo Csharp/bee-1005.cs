using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1005
    {
        public static void X(String[] args)
        {
            double A, B, PesoA, PesoB, Media;

            PesoA = 3.5;
            PesoB = 7.5;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Media = ((A * PesoA) + (B * PesoB)) / (PesoA + PesoB);

            Console.WriteLine("MEDIA = " + Media.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
