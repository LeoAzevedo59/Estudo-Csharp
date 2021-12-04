using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1009
    {
        public static void x(String[] args)
        {
            string nome;
            double SalarioFixo, VendasMensais, Total;

            nome = Console.ReadLine();

            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VendasMensais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Total = (VendasMensais * 0.15) + SalarioFixo;

            Console.WriteLine("TOTAL = R$ " + Total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
