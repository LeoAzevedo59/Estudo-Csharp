using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _17Vetor03
    {
        public static void X(String[] args)
        {
            int X;
            double Soma, Media;

            Soma = 0;

            double[] A;

            X = int.Parse(Console.ReadLine());
            A = new double[X];

            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < X; i++)
            {
                A[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                Soma += double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            for (int a = 0; a < X; a++)
            {
                if (a != (X - 1))
                    Console.Write(A[a] + " ");
                else
                    Console.WriteLine(A[a]);
            }

            Console.WriteLine(Soma.ToString("F2", CultureInfo.InvariantCulture));
            Media = Soma / X;
            Console.WriteLine(Media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
