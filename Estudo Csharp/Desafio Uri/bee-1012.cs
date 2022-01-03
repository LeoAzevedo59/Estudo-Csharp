using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1012
    {
        public static void x(String[] args)
        {
            double A, B, C, Triangulo, Circulo, Trapezio, Quadrado, Retangulo, PI;
            PI = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Triangulo = A * C / 2.0;
            Circulo = PI * Math.Pow(C, 2);
            Trapezio = ((A + B) * C) / 2;
            Quadrado = Math.Pow(B, 2);
            Retangulo = A * B;


            Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
