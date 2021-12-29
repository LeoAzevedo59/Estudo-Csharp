using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class prova_00
    {
        static void X(String[] args)
        {
            int Quantidade;
            double ValorUnitario, total;

            string[] vet = Console.ReadLine().Split(' ');
            Quantidade = int.Parse(vet[1]);
            ValorUnitario = double.Parse(vet[2], CultureInfo.InvariantCulture);
            total = (Quantidade * ValorUnitario);


            string[] vet2 = Console.ReadLine().Split(' ');
            Quantidade = int.Parse(vet2[1]);
            ValorUnitario = double.Parse(vet2[2], CultureInfo.InvariantCulture);
            total += (Quantidade * ValorUnitario);
            
            Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
