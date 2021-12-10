using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1117
    {
        public static void X(String[] vet)
        {
            double Media, X, Y;

            X = 0;
            Y = 0;


            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (X < 0.0 || X > 10.0)
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



        }
    }
}
