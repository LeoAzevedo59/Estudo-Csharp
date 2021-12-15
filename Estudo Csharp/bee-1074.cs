using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1074
    {
        static void X(String[] args)
        {
            int QtdeCasos, X;

            QtdeCasos = int.Parse(Console.ReadLine());

            for (int i = 0; i < QtdeCasos; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X == 0)
                    Console.WriteLine("NULL");
                else if (X % 2 != 0)
                {
                    if (X > 0)
                        Console.WriteLine("ODD POSITIVE");
                    else
                        Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    if (X > 0)
                        Console.WriteLine("EVEN POSITIVE");
                    else
                        Console.WriteLine("EVEN NEGATIVE");
                }                        
            }
        }
    }
}
