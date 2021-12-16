using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1094
    {
        static void x(String[] args)
        {
            int QtdeCasos, Experimento, Rato, Sapo, Coelho, Total;
            char Animal;
            double PorRato, PorSapo, PorCoelho;

            Rato = 0;
            Sapo = 0;
            Coelho = 0;


            QtdeCasos = int.Parse(Console.ReadLine());

            for (int i = 0; i < QtdeCasos; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                Experimento = int.Parse(vet[0]);
                Animal = char.Parse(vet[1]);

                if (Animal == 'C')
                    Coelho += Experimento;
                else if (Animal == 'R')
                    Rato += Experimento;
                else
                    Sapo += Experimento;
            }

            Total = Coelho + Rato + Sapo;

            PorCoelho = (Coelho * 100.0) / Total;
            PorSapo = (Sapo * 100.0) / Total;
            PorRato = (Rato * 100.0) / Total;

            Console.WriteLine("Total: " + Total + " cobaias");
            Console.WriteLine("Total de coelhos: " + Coelho);
            Console.WriteLine("Total de ratos: " + Rato);
            Console.WriteLine("Total de sapos: " + Sapo);
            Console.WriteLine("Percentual de coelhos: " + PorCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + PorRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + PorSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
