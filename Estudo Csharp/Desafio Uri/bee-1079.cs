using System;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1079
    {
        static void X(String[] args)
        {
            int QtdeCasos;
            double Media;

            QtdeCasos = int.Parse(Console.ReadLine());

            for (int i = 0; i < QtdeCasos; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                Media = ((double.Parse(vet[0], CultureInfo.InvariantCulture) * 2) +
                         (double.Parse(vet[1], CultureInfo.InvariantCulture) * 3) +
                         (double.Parse(vet[2], CultureInfo.InvariantCulture) * 5)) /
                         (2 + 3 + 5);
                Console.WriteLine(Media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
