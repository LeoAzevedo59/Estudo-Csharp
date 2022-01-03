using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1115
    {
        public static void X(string[] args)
        {
            int X, Y;

            X = 1;
            Y = 1;

            while (X != 0 && Y != 0)
            {
                string[] vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (X != 0 && Y != 0)
                {
                    if (X > 0 && Y > 0)
                        Console.WriteLine("primeiro");
                    if (X > 0 && Y < 0)
                        Console.WriteLine("quarto");
                    if (X < 0 && Y < 0)
                        Console.WriteLine("terceiro");
                    if (X < 0 && Y > 0)
                        Console.WriteLine("segundo");
                }
            }
        }
    }
}
