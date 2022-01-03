using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double P = (A + B + C) / 2.0;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
}
