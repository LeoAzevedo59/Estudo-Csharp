using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Foreach
{
    class app_foreach
    {
        static void X(String[] args)
        {
            string[] vet = Console.ReadLine().Split(',');

            foreach (var item in vet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
