using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1075
    {
        static void X(String[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10000; i++)
            {
                if (i % X == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
