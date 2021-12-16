using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1132
    {
        static void X(String[] args)
        {
            int X, Y, S, B;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            S = 0;

            if (X > Y)
            {
                B = X;
                X = Y;
                Y = B;
            }

            for (int i = X; i <= Y; i++)
            {
                if (i % 13 != 0)
                {
                    S += i;
                }
            }

            Console.WriteLine(S);
        }
    }
}
