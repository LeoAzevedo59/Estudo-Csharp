using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _18Vetor04
    {
        static void X(String[] args)
        {
            int X, Idade, TotalIdade;
            double Altura, AlturaTotal, AlturaMedia, PorcIdade;
            string Nome;

            AlturaTotal = 0;
            TotalIdade = 0;

            X = int.Parse(Console.ReadLine());

            for (int i = 0; i < X; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                Nome = vet[0];
                Idade = int.Parse(vet[1]);
                Altura = Double.Parse(vet[2], CultureInfo.InvariantCulture);

                AlturaTotal += Altura;

                if (Idade < 16)
                    TotalIdade += 1;
            }
            AlturaMedia = AlturaTotal / X;
            PorcIdade = 100 * TotalIdade / X;

            Console.WriteLine("Altura média: " + AlturaMedia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: " + PorcIdade.ToString("F1", CultureInfo.InvariantCulture) + "%");

        }
    }
}
