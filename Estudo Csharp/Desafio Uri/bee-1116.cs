using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1116
    {
        static void X(String[] args)
        {
            int QtdeCasos;
            double Total, A, B;

            QtdeCasos = int.Parse(Console.ReadLine());

            for (int i = 0; i < QtdeCasos; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                A = double.Parse(vet[0]);
                B = double.Parse(vet[1]);

                if (B == 0)
                    Console.WriteLine("divisao impossivel");
                else
                {
                    Total = A / B;
                    Console.WriteLine(Total.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
