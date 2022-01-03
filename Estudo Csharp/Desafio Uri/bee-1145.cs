using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1145
    {
        static void X(String[] args)
        {
            int X, Y, B;

            B = 0;

            string[] vet = Console.ReadLine().Split(' ');

            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            for (int i = 1; i <= Y; i++)
            {
                B += 1;
                if (B != X)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine(i);
                    B = 0;
                }
            }
        }
    }
}
