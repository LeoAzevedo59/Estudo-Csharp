using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1078
    {
        public static void X(String[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " x " + X + " = " + (X * i));
            }
        }
    }
}
