using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1071
    {
        public static void X(String[] args)
        {
            int X, Y, Maior, Menor, Soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            Soma = 0;

            if (X > Y)
            {
                Maior = X;
                Menor = Y;
            }
            else
            {
                Maior = Y;
                Menor = X;
            }


            for (int i = Menor + 1; i < Maior; i++)
            {

                if ((i % 2) != 0)
                {
                    Soma += i;
                }

            }
            Console.WriteLine(Soma);
        }
    }
}
