using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Estudo_Csharp
{
    class _10EstruturaCondicional
    {
        public static void X(String[] args)
        {
            int A, B, C;

            String[] vet = Console.ReadLine().Split(' ');

           A = int.Parse(vet[0]);
           B = int.Parse(vet[1]);
           C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                Console.WriteLine("MENOR = " + A);
            }
            if(B < A && B < C)
            {
                Console.WriteLine("MENOR = " + B);
            }
            else
            {
                Console.WriteLine("MENOR = " + C);
            }
        }
    }
}
