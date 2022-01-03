using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _16Vetor02
    {
        static void X(String[] args)
        {
            int X;
            int[] A;

            X = int.Parse(Console.ReadLine());
            A = new int[X];

            string[] vet = Console.ReadLine().Split(' ');

            for (int b = 0; b < X; b++)
            {
                A[b] = int.Parse(vet[b]);
            }

            for (int a = 0; a < X; a++)
            {
                if (A[a] < 0)
                {
                    Console.WriteLine(A[a]);
                }
            }
        }
    }
}

