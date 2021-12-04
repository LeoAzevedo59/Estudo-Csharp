using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class _07CalculoMetematico
    {
        public static void X(String[] args)
        {
            double A, B, Area, Perimetro, Diagonal, dig;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = A * B;
            Perimetro = A * 2 + B * 2;
            dig = (Math.Pow(A, 2) + Math.Pow(B, 2));  
            Diagonal = Math.Sqrt(dig);

            Console.WriteLine("AREA = " + Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + Diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
