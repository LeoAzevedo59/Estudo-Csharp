using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Matriz
{
    class App_Matriz
    {
        static void X(String[] args)
        {
            int Linha, Coluna;

            string[] vet = Console.ReadLine().Split(" ");

            Linha = int.Parse(vet[0]);
            Coluna = int.Parse(vet[1]);

            int[,] matriz = new int[Linha, Coluna];

            for (int i = 0; i < Linha; i++)
            {
                string[] vetor = Console.ReadLine().Split(" ");

                for (int j = 0; j < Coluna; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);

                }

            }

            for (int i = 0; i < Linha; i++)
            {
                for (int j = 0; j < Coluna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
