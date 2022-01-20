using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Matriz
{
    class MatrizQuadrada
    {
        static void X(String[] args)
        {
            int LC, count = 0;

            LC = int.Parse(Console.ReadLine());

            int[,] matriz = new int[LC, LC];

            for (int i = 0; i < LC; i++)
            {
                string[] vet = Console.ReadLine().Split(" ");

                for (int j = 0; j < LC; j++)
                {
                    matriz[i, j] = int.Parse(vet[j]);

                    if (matriz[i, j] < 0)
                        count += 1;
                }
            }
            Console.WriteLine("Main Diagonal:");
            for (int i = 0; i < LC; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.Write("\n" + "Negative numbers = " + count);
            Console.WriteLine();
        }
    }
}
