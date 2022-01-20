using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.Csharp
{
    class _19ExpressaoCondicionalTernaria
    {
        static void X(String[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            //if (preco < 20)
            //    desconto = preco * 0.1;
            //else
            //    desconto = preco * 0.05;

            desconto = (preco < 20) ? desconto = preco * 0.1 : desconto = preco * 0.05;

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
