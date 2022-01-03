using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1143
    {
        static void X(String[] args)
        {
            int qtdeCasos;
            double X;

            qtdeCasos = int.Parse(Console.ReadLine());

            for (int i = 1; i < qtdeCasos + 1; i++)
            {
                X = i;
                Console.Write(i + " ");
                X *= i;
                Console.Write(X + " ");
                X *= i;
                Console.WriteLine(X);
            }
        }
    }
}
