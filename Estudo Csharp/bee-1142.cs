using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1142
    {
        static void X(String[] args)
        {
            int qtdeCasos;
            int A = 1;
            int X = 0;
            qtdeCasos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdeCasos; i++)
            {
                Console.Write(A + " ");
                A += 1;
                Console.Write(A + " ");
                A += 1;
                Console.Write(A + " ");
                A += 2;
                Console.WriteLine("PUM");
            }
        }
    }
}
