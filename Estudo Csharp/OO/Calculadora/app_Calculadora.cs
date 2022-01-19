using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Calculadora
{
    class app_Calculadora
    {
        static void X(String[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int soma;

            Calculadora.Trip1(a, out soma);

            Console.WriteLine(soma);
        }
    }
}
