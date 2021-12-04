using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1013
    {
        public static void X(String[] args)
        {
            int A, B, C, result, maior;

            string[] vet = Console.ReadLine().Split(' ');
            
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            result = (A + B + Math.Abs(A - B)) / 2;
            maior = (result + C + Math.Abs(result - C)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
