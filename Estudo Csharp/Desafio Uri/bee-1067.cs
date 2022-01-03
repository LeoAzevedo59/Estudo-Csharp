using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1067
    {
        static void X(String[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
                X -= 1;

            for (int i = 1; i < X + 1; i++)
            {

                if ((i % 2) != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
