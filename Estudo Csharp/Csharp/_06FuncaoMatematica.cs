using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class _06FuncaoMatematica
    {
        public static void X(String[] args)
        {

            double largura, comprimento, preco, area;
            largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = largura * comprimento;
            preco = area * preco;

            Console.WriteLine("AREA = " + area.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
