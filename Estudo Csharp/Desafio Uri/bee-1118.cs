using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1118
    {
        public static void x(String[] vet)
        {
            double Media, X, Y;
            int Opcao;

            X = 0;
            Y = 0;
            Opcao = 0;

            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (X >= 0 || X <= 10)
            {
                while (Opcao != 2)
                {
                    while (X < 0 || X > 10)
                    {
                        Console.WriteLine("nota invalida");
                        X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }

                    Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    while (Y < 0 || Y > 10)
                    {
                        Console.WriteLine("nota invalida");
                        Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }

                    Media = (X + Y) / 2.0;
                    Console.WriteLine("media = " + Media.ToString("F2", CultureInfo.InvariantCulture));

                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    Opcao = int.Parse(Console.ReadLine());

                    while (Opcao != 2 && Opcao != 1)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        Opcao = int.Parse(Console.ReadLine());
                    }

                    if (Opcao == 1)
                        X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
