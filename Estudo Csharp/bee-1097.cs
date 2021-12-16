using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1097
    {
        static void x(String[] args)
        {
            int X = 7;

            for (int i = 0; i < 9; i++)
            {
                i += 1;

                Console.WriteLine("I=" + i + " J=" + X);
                X -= 1;
                Console.WriteLine("I=" + i + " J=" + X);
                X -= 1;
                Console.WriteLine("I=" + i + " J=" + X);
                X = X + 4;
            }
        }
    }
}
