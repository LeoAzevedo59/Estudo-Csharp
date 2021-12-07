using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1038
    {
        public static void X(String[] args)
        {
            int ID, Qtde;
            double preco;

            string[] vet = Console.ReadLine().Split(' ');

            ID = int.Parse(vet[0]);
            Qtde = int.Parse(vet[1]);
            preco = 0;

            switch (ID)
            {
                case 1:
                    preco = 4.00;
                    break;
                case 2:
                    preco = 4.50;
                    break;
                case 3:
                    preco = 5.00;
                    break;
                case 4:
                    preco = 2.00;
                    break;
                case 5:
                    preco = 1.50;
                    break;
                default:
                    Console.WriteLine("Código Errado!");
                    break;

            }
                    preco *= Qtde;
            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
