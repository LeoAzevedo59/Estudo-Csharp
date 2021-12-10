using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1159
    {
        public static void X(String[] args)
        {
            int X, SOMA;

            SOMA = 0;


            X = int.Parse(Console.ReadLine()); 
            while (X != 0)
            {
                if (X % 2 != 0)
                {
                    X = X + 1;
                }
                SOMA = X + (X + 2) + (X + 4) + (X + 6) + (X + 8);
                Console.WriteLine(SOMA);

                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
