using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1072
    {
        static void X(String[] args)
        {
            int CasoDeTeste, X, dentro, fora;

            dentro = 0;
            fora = 0;

            CasoDeTeste = int.Parse(Console.ReadLine());


            for (int i = 0; i < CasoDeTeste; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                    dentro += 1;
                else
                    fora += 1;
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
