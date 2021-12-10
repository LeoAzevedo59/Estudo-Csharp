using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _12EstruturaRepetitiva
    {
        public static void X(String[] args)
        {
            int x, soma;

            soma = 0;
            x = 1;

            while (x != 0)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine(soma);
        }
    }
}
