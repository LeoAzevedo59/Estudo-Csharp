using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1073
    {
        static void X(String[] args)
        {
            int X;
            double Q;

            X = int.Parse(Console.ReadLine());


            if (X % 2 != 0)
                X += 1;

            for (int i = 2; i < X +1; i++)
            {
                Q = Math.Pow(i, 2);
                if (i % 2 == 0)
                    Console.WriteLine(i + "^2 = " + Q);
            }
        }
    }
}
