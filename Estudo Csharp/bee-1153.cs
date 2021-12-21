using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1153
    {
        static void X(String[] args)
        {
            int X, soma;
            soma = 1;

            X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                soma *= i; 
            }
            Console.WriteLine(soma);

        }
    }
}