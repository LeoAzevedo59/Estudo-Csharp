using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1101
    {
        static void X(String[] args)
        {
            int X, Y, B, Soma;

            X = 0;
            Y = 0;
            B = 0;
            Soma = 0;

            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);


            while (X > 0 && Y > 0)
            {

                if (X > 0 || Y > 0)
                {
                    if (X > Y)
                    {
                        B = X;
                        X = Y;
                        Y = B;
                    }

                    for (int i = X; i <= Y; i++)
                    {
                        Console.Write(i + " ");

                        Soma += i;
                    }

                    Console.WriteLine("Sum=" + Soma);

                    vet = Console.ReadLine().Split(' ');
                    Soma = 0;
                    X = int.Parse(vet[0]);
                    Y = int.Parse(vet[1]);
                }
            }
        }
    }

}


