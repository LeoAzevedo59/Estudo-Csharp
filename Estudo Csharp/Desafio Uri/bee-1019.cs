using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1019
    {
        public static void X(String[] args)
        {
            int ValorBruto, Horas, Minutos, Segundos, Resto;

            ValorBruto = int.Parse(Console.ReadLine());

            Segundos = ValorBruto % 60;
            Resto = ValorBruto / 60;
            Minutos = Resto % 60;
            Horas = Resto / 60;

            Console.WriteLine(Horas + ":" + Minutos + ":" + Segundos);
        }
    }
}
