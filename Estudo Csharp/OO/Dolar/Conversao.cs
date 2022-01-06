using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Dolar
{
    class Conversao
    {
        public static double Dolar;
        public static double CompraDolar;

        public static double Conv()
        {
            double total = (Dolar * CompraDolar);
            return total + (total * 0.06);
        }
    }
}
