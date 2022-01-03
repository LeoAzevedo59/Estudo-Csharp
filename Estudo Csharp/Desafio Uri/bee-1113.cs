using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1113
    {
        public static void X(String[] args)
        {

            int X, Y;

            X = 1;
            Y = 0;

            while (X != Y)
            {
                string[] vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (X != Y)
                {
                    if (X > Y)
                        Console.WriteLine("Decrescente");
                    else
                        Console.WriteLine("Crescente");
                }
            }
        }
    }
}
