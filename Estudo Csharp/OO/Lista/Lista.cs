using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Lista
{
    class Lista
    {
        static void X(String[] args)
        {
            List<string> nome = new List<string>();

            int count = 0;

            nome.Add("Léo");
            nome.Add("Rodolfo");
            nome.Add("Loh");
            nome.Add("Fernanda");
            nome.Add("Carlos");
            nome.Insert(2, "Jeorge");

            foreach (string item in nome)
            {
                Console.WriteLine(count + " "+ item);
                count += 1;
            }

            count = 0;
            Console.WriteLine();

            nome.Remove("Léo");

            foreach (string item in nome)
            {
                Console.WriteLine(count + " " + item);
                count += 1;
            }

        }
    }
}
