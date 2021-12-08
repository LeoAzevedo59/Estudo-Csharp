using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1037
    {
        public static void X(String[] args)
        {
            double X;
            string intervalo;

            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            intervalo = "Fora de intervalo";

            if (X >= 0.00 && X <= 25.00)
            {
                intervalo = "Intervalo (0,25]";

            }
            if (X >= 25.01 && X <= 50.00)
            {

                intervalo = "Intervalo (25,50]";
            }
            if (X >= 50.01 && X <= 75.00)
            {

                intervalo = "Intervalo (50,75]";
            }
            if (X >= 75.01 && X <= 100.00)
            {

                intervalo = "Intervalo (75,100]";
            }

            Console.WriteLine(intervalo);
        }
    }
}
