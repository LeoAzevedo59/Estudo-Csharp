using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1046
    {
        public static void X(String[]args)
        {
            int A, B, Duracao;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            Duracao = 0;

            if (A > B)
            {
                Duracao = (24 - A) + B;
            }
            if(A == B)
            {
                Duracao = 24;
            }
            if (A < B)
            {
                Duracao = B - A;
            }

            Console.WriteLine("O JOGO DUROU " + Duracao + " HORA(S)");
        }
    }
}
