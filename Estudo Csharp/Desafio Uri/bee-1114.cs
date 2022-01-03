using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1114
    {
        public static void X(String[] args)
        {
            int Senha;

            Senha = 0;

            Senha = int.Parse(Console.ReadLine());
            if (Senha != 2002)
            {
                while (Senha != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                    Senha = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
