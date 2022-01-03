using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1017
    {
        public static void X(String[] args)
        {
            int TempoViagem, VelocidadeMedia;
            double LitrosComb;

            TempoViagem = int.Parse(Console.ReadLine());
            VelocidadeMedia = int.Parse(Console.ReadLine());

            LitrosComb = (TempoViagem * VelocidadeMedia) / 12.0;

            Console.WriteLine(LitrosComb.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
