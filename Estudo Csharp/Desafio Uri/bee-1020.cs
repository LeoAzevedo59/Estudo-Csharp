using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1020
    {
        public static void X
            (String [] args)
        {
            int Bruto, Ano, Mes, Dia;

            Bruto = int.Parse(Console.ReadLine());

            Ano = Bruto / 365;
            Mes = (Bruto % 365) / 30;
            Dia = ((Bruto % 365) % 30);

            Console.WriteLine(Ano + " ano(s)");
            Console.WriteLine(Mes + " mes(es)");
            Console.WriteLine(Dia + " dia(s)");
        }
    }
}
