using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class prova_05
    {
        static void Main(String[] args)
        {
            int N, X, Dentro, Fora;

            Dentro = 0;
            Fora = 0;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    Dentro += 1;
                }
                else
                {
                    Fora += 1;
                }
            }

            Console.WriteLine(Dentro + " in" + "\n" + Fora + " out");
        }
    }
}
