using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class prova_02
    {
        static void X(String[] args)
        {
            int Codigo, Quantidade;
            double preco;

            preco = 0;

            string[] vet = Console.ReadLine().Split(' ');

            Codigo = int.Parse(vet[0]);
            Quantidade = int.Parse(vet[1]);

            switch (Codigo)
            {
                case (1):
                    preco = 4.00;
                    break;
                case (2):
                    preco = 4.50;
                    break;
                case (3):
                    preco = 5.00;
                    break;
                case (4):
                    preco = 2.00;
                    break;
                case (5):
                    preco = 1.50;
                    break;
            }

            preco *= Quantidade;

            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
