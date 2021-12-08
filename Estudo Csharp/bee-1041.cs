using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1041
    {
        public static void X(String[] args)
        {
            double X, Y;
            string Q;

            string[] vet = Console.ReadLine().Split(' ');

            X = double.Parse(vet[0]);
            Y = double.Parse(vet[1]);
            Q = "";

            if (X == 0 && Y == 0)
                Q = "Origem";
            if(X == 0)
                Q = "Eixo Y";
            if (Y == 0)
                Q = "Eixo X";
            if (X > 0 && Y > 0)
                Q = "Q1";
            if (X < 0 && Y > 0)
                Q = "Q2";
            if (X < 0 && Y < 0)
                Q = "Q3";
            if (X > 0 && Y < 0)
                Q = "Q4";

            Console.WriteLine(Q);
        }
    }
}
