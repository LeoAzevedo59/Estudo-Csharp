using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1133
    {
        static void X(String[] args)
        {
            int X, Y, B;

            B = 0;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                B = X;
                X = Y;
                Y = B;
            }

            if (X > 0 && Y > 0)
            {
                for (int i = X+1; i < Y; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                        Console.WriteLine(i);
                }
            }
        }
    }
}
