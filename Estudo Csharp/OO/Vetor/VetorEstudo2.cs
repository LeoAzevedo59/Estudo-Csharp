using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Vetor
{
    class VetorEstudo2
    {
        static void X(String[] args)
        {
            int Qtde;
            double Sum;

            Sum = 0;

            Qtde = int.Parse(Console.ReadLine());

            double[] vet = new double[Qtde];

            for (int i = 0; i < Qtde; i++)
            {
                Console.ReadLine();
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Sum += vet[i];
            }

            double Media;

            Media = Sum / Qtde;
            Console.WriteLine("AVERAGE PRICE = " + Media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
