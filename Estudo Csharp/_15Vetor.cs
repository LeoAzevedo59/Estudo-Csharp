using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _15Vetor
    {
        static void X(String[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            double[] A;

            A = new double[X];

            for (int i = 0; i < X; i++)
            {
                A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int a = 0; a < X; a++)
            {
                Console.WriteLine(A[a].ToString("F1",CultureInfo.InvariantCulture));
            }

        }
    }
}
