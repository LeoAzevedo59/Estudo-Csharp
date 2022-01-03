using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class prova_03
    {
        static void X(string[] args)
        {
            double A, B, C, Delta, X1, X2;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Delta = Math.Pow(B, 2) - (4 * A * C);

            if (A == 0 || Delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                X1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
                X2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);
                Console.WriteLine("X1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}

