using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1151
    {
        static void Main(String[] args)
        {
            int Sequencia, X, Y, B;
            Sequencia = int.Parse(Console.ReadLine());
            X = 0;
            Y = 1;
            B = 0;

            for (int i = 0; i < Sequencia - 1; i++)
            {
                if (i <= 1)
                    Console.Write(i + " ");
                else
                {
                    X = X + Y;
                    Console.Write(X + " ");
                    B = X;
                    X = Y;
                    Y = B;
                }
            }
            X = X + Y;
            Console.WriteLine(X);
        }
    }
}
