using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class _08MediaDeIdade
    {
        public static void X(String[] args)
        {
            string NomeA, NomeB;
            int IdadeA, IdadeB;
            double MediaIdade;

            string[] vet = Console.ReadLine().Split(' ');
            NomeA = vet[0];
            IdadeA = int.Parse(vet[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            NomeB = vet2[0];
            IdadeB = int.Parse(vet2[1], CultureInfo.InvariantCulture);

            MediaIdade = (IdadeA + IdadeB) / 2.0;

            Console.WriteLine("A idade media de " + NomeA + " e " + NomeB + " é de " + MediaIdade.ToString("F1", CultureInfo.InvariantCulture) + " anos");


        }
    }
}
