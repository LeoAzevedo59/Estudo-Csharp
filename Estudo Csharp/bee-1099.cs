using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1099
    {
        static void X(String[] args)
        {
            int qtdeCasos, X, Y, B, Result;

            qtdeCasos = int.Parse(Console.ReadLine());
            X = 0;
            Y = 0;
            Result = 0;

            for (int i = 0; i < qtdeCasos; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (X > Y)
                {
                    B = Y;
                    Y = X;
                    X = B;
                }

                for (int a = X+1; a < Y; a++)
                {
                    if (a % 2 != 0)
                    {
                        Result += a;
                    }
                }
                Console.WriteLine(Result);
                Result = 0;

            }


        }
    }
}
