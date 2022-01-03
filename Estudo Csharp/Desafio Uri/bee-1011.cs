using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Estudo_Csharp
{
    class bee_1011
    {
        public static void X(String[] args)
        {
            int Raio;
            double Volume, PI;

            PI = 3.14159;

            Raio = int.Parse(Console.ReadLine());


            Volume = ((4 / 3.0) * PI) * Math.Pow(Raio, 3);




            Console.WriteLine("VOLUME = " + Volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
