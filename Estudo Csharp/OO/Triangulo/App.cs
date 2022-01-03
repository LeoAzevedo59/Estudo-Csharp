using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO
{
    class App
    {
        static void X(String[] args)
        {
            double AreaX, AreaY, P;

            Console.WriteLine("Entre com as medidas do triangulo X:");

            Triangulo TrianguloX = new Triangulo();
            Triangulo TrianguloY = new Triangulo();

            TrianguloX.A = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
            TrianguloX.B = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
            TrianguloX.C = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y:");
            TrianguloY.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TrianguloY.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TrianguloY.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            AreaX = TrianguloX.Area();
            Console.WriteLine("Área de X = " + AreaX.ToString("F4", CultureInfo.InvariantCulture));

            AreaY = TrianguloY.Area();
            Console.WriteLine("Área de X = " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if (AreaX > AreaY)
                Console.WriteLine("Maior área: X");
            else
                Console.WriteLine("Maior área: Y");
        }
    }
}
