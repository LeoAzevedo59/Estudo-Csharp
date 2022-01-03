using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1157
    {
        static void X(String[] args)
        {
            int X;

            X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (X % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
