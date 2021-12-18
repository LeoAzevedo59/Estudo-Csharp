using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1144
    {
        static void X(String[] args)
        {
            int qtdeCasos, A, B, X;
            A = 0;
            B = 0;

            qtdeCasos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeCasos; i++)
            {
                X = i;
                A = X * X;
                B = A * i;
                Console.WriteLine(i + " " + A + " " + B);
                A += 1;
                B += 1;
                Console.WriteLine(i + " " + A + " " + B);
            }
        }
    }
}
