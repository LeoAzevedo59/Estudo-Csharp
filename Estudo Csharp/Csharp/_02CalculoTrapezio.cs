using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _02CalculoTrapezio
    {
        static void X(String[] arg)
        {
            int BaseMenor, BaseMaior, Altura, Area;

            BaseMenor = int.Parse(Console.ReadLine());
            BaseMaior = int.Parse(Console.ReadLine());
            Altura = int.Parse(Console.ReadLine());

            Area = (BaseMenor + BaseMaior) / 2 * Altura;

            Console.WriteLine("Base Menor: " + BaseMenor + " Base Maior: " + BaseMaior + " Altura: " + Altura + " Area = " + Area);
        }
    }
}
