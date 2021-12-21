using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1156
    {
        static void X(String[] args)
        {
            double S, X, Y;

            X = 3;
            Y = 2;
            S = 1;

            for (int i = 0; i <= 19; i++)
            {
                S += (X / Y);
                X += 2.0;
                Y *= 2.0;
            }
            Console.WriteLine(S.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
