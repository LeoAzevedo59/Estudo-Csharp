using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1131
    {
        public static void Main(String[] args)
        {
            int Inter, Gremio, Grenais, GolInter, GolGremio, Empate, Total;

            Grenais = 1;
            Empate = 0;
            GolInter = 0;
            GolGremio = 0;

            while (Grenais == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');
                Inter = int.Parse(vet[0]);
                Gremio = int.Parse(vet[1]);

                if (Inter > Gremio)
                    GolInter += 1;
                else if (Gremio > Inter)
                    GolGremio += 1;
                else
                    Empate += 1;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                Grenais = int.Parse(Console.ReadLine());
            }

            Total = GolGremio + GolInter + Empate;

            Console.WriteLine(Total + " grenais");
            Console.WriteLine("Inter: " + GolInter);
            Console.WriteLine("Gremio: " + GolGremio);
            Console.WriteLine("Empate: " + Empate);

            if (GolInter > GolGremio)
                Console.WriteLine("Inter venceu mais");
            else if (GolGremio > GolInter)
                Console.WriteLine("Gremio venceu mais");
            else
                Console.WriteLine("Nao houve vencedor");
        }
    }
}
