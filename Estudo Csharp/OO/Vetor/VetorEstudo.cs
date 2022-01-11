using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.nullable
{
    class VetorEstudo
    {
        static void x(String[] args)
        {
            int Qtde;
            double Media, Altura;

            Altura = 0;
            Media = 0;

            Qtde = int.Parse(Console.ReadLine());

            double[] vet = new double[Qtde];

            for (int i = 0; i < Qtde; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Altura += vet[i];

                Media = Altura / Qtde;

            }

            Console.WriteLine(Media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
