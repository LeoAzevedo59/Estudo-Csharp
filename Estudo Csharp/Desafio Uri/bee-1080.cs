using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1080
    {
        static void X(String[] args)
        {
            int X, P, Posicao;
            P = 0;
            Posicao = 0;

            for (int i = 0; i < 5; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X > P)
                {
                    P = X;
                    Posicao = i+1;
                }
            }

            Console.WriteLine(P);
            Console.WriteLine(Posicao);
        }
    }
}
