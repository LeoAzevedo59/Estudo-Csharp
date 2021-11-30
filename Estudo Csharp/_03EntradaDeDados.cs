using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _03EntradaDeDados
    {
        public static void X(String[] arg)
        {
            string Frase, x, y, z, a, b, c;

            Frase = (Console.ReadLine());
            x = (Console.ReadLine());
            y = (Console.ReadLine());
            z = (Console.ReadLine());

            string []vet = Console.ReadLine().Split(' ');

            a = vet[0];
            b = vet[1];
            c = vet[2];

            Console.WriteLine(Frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
