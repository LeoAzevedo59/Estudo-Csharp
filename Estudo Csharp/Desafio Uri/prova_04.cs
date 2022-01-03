using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class prova_04
    {
        static void X(String[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Acesso Permitido");
        }
    }
}
