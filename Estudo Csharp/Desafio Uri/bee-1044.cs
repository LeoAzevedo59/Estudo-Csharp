using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1044
    {
        static void X(string[] args)
        {
            int A, B;

            String[] vet = Console.ReadLine().Split();

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (B % A == 0 || A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
