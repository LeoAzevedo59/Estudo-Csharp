using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Matriz
{
    class SuperDesafioMatriz
    {
        static void X(String[] args)
        {
            string[] vet;
            string[] vetor;
            int numb;
            int count = 0;

            vet = Console.ReadLine().Split(" ");

            int[,] matriz = new int[int.Parse(vet[0]), int.Parse(vet[1])];


            for (int i = 0; i < int.Parse(vet[0]); i++)
            {
                vetor = Console.ReadLine().Split(" ");
                for (int j = 0; j < int.Parse(vet[1]); j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < int.Parse(vet[0]); i++)
            {
                for (int j = 0; j < int.Parse(vet[1]); j++)
                {
                    if (matriz[i, j] == numb)
                        count += 1;
                }
            }

            for (int i = 0; i < int.Parse(vet[0]); i++)
            {

                for (int j = 0; j < int.Parse(vet[1]); j++)
                {

                    if (matriz[i, j] == numb)
                    {
                        Console.WriteLine("POSIÇÃO " + "[" + i + "," + j + "]");
                        var w = i;
                        var z = j;

                        var linha = int.Parse(vet[0]) - 1;
                        var coluna = int.Parse(vet[1]) - 1;


                        if (i == 0 || j == 0 || i == linha || j == coluna)
                        {
                            if (i == 0 && j == 0)
                            {
                                Console.WriteLine("DIREITA: " + matriz[w, ++z]);
                                w = i;
                                z = j;
                                Console.WriteLine("BAIXO: " + matriz[++w, z]);
                                w = i;
                                z = j;

                                //10
                            }
                            if (i == 0 && j == coluna)
                            {
                                Console.WriteLine("BAIXO: " + matriz[++w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("ESQUERDA: " + matriz[w, --z]);
                                w = i;
                                z = j;
                                //12
                            }
                            if (i == linha && j == coluna)
                            {
                                Console.WriteLine("TOPO: " + matriz[--w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("ESQUERDA: " + matriz[w, --z]);
                                w = i;
                                z = j;
                                //19
                            }
                            if (i == linha && j == 0)
                            {
                                Console.WriteLine("TOPO: " + matriz[--w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("DIREITA: " + matriz[w, ++z]);
                                w = i;
                                z = j;
                                //14
                            }
                            if (i != 0 && i != linha && j == 0)
                            {
                                Console.WriteLine("TOPO: " + matriz[--w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("DIREITA: " + matriz[w, ++z]);
                                w = i;
                                z = j;
                                Console.WriteLine("BAIXO: " + matriz[++w, z]);
                                w = i;
                                z = j;
                                //21
                            }
                            if (i == linha && j != coluna && j != 0)
                            {
                                Console.WriteLine("TOPO: " + matriz[--w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("DIREITA: " + matriz[w, ++z]);
                                w = i;
                                z = j;
                                Console.WriteLine("ESQUERDA: " + matriz[w, --z]);
                                w = i;
                                z = j;
                                //13
                            }
                            if (i != 0 && i != linha && j == coluna)
                            {
                                Console.WriteLine("TOPO: " + matriz[--w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("BAIXO: " + matriz[++w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("ESQUERDA: " + matriz[w, --z]);
                                w = i;
                                z = j;
                                //8
                            }
                            if (i == 0 && j != 0 && j != coluna)
                            {
                                Console.WriteLine("DIREITA: " + matriz[w, ++z]);
                                w = i;
                                z = j;
                                Console.WriteLine("BAIXO: " + matriz[++w, z]);
                                w = i;
                                z = j;
                                Console.WriteLine("ESQUERDA: " + matriz[w, --z]);
                                w = i;
                                z = j;
                                //15
                            }
                        }
                        else
                        {
                            Console.WriteLine("TOPO: " + matriz[--w, z]);
                            w = i;
                            z = j;
                            Console.WriteLine("DIREITA: " + matriz[w, ++z]);
                            w = i;
                            z = j;
                            Console.WriteLine("BAIXO: " + matriz[++w, z]);
                            w = i;
                            z = j;
                            Console.WriteLine("ESQUERDA: " + matriz[w, --z]);
                            w = i;
                            z = j;
                        }

                        Console.WriteLine();
                        if (count != 0)
                            count -= 1;
                        else
                            numb = -1;
                    }

                }
            }

        }
    }
}
