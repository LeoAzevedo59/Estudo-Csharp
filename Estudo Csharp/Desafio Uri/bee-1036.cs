using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1036
    {
        public static void X(String[] args)
        {
            double A, B, C, Delta, X1, X2;

            String[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Delta = Math.Pow(B, 2) - 4 * A * C;

            if (A == 0 || Delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }

            X1 = (-B + Math.Sqrt(Delta)) / (2 * A);
            X2 = (-B - Math.Sqrt(Delta)) / (2 * A);

            Console.WriteLine("R1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
