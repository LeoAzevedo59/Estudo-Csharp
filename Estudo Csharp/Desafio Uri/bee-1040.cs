using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1040
    {
        public static void X(String[] args)
        {
            double P1, P2, P3, P4, Media, Exame, NovaNota;
            string msg, msgNova;

            String[] vet = Console.ReadLine().Split(' ');

            P1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            P2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            P3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            P4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Media = (P1 * 2.0 + P2 * 3.0 + P3 * 4.0 + P4 * 1.0) / (2.0 + 3.0 + 4.0 + 1.0);

            msg = "";
            Exame = 0;
            NovaNota = 0;

            if (Media >= 7.0)
                msg = "Aluno Aprovado.";
            if (Media >= 5.0 && Media <= 6.9)
            {
                msg = "Aluno em exame.";
            }
            if (Media < 5.0)
                msg = "Aluno reprovado.";


            Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(msg);

            if (Media >= 5.0 && Media <= 6.9)
            {
                Exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                NovaNota = (Media + Exame) / 2.0;
            }

            if (NovaNota >= 5.0)
                msgNova = "Aluno aprovado.";
            else
                msgNova = "Aluno reprovado.";

            Console.WriteLine("Nota do exame: " + Exame.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(msgNova);
            Console.WriteLine("Media final: " + NovaNota.ToString("F1",CultureInfo.InvariantCulture));

        }
    }
}
