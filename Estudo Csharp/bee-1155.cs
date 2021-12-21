using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1155
    {
        static void X(String[] args)
        {
            double X, Total;

            Total = 0;

            for (int i = 1; i <= 100; i++)
            {
                X = (1.0 / i);
                Total += X;

            }

                Console.WriteLine(Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
