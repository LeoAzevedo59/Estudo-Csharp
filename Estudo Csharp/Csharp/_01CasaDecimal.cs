using System;
using System.Globalization;

namespace Estudo_Csharp
{
    class _01CasaDecimal
    {
        static void x(string[] args)
        {
            double x = 10.35784;

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
