using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Quartos
{
    class appCadastro
    {
        static void X(String[] args)
        {
            Cadastro[] vect = new Cadastro[10];
            Cadastro x = new Cadastro();
            int numb = 0;

            Console.Write("How many rooms will rented? ");
            int Qtde = int.Parse(Console.ReadLine());

            for (int i = 0; i < Qtde; i++)
            {
                Console.WriteLine();
                numb += 1;

                Console.WriteLine("Rent #" + numb + ":");
                Console.Write("Name: ");
                string Nome = Console.ReadLine();
                Console.Write("Email: ");
                string Email = Console.ReadLine();
                Console.Write("Room: ");
                int Quarto = int.Parse(Console.ReadLine());

                vect[Quarto] = new Cadastro {Nome = Nome, Email = Email, Quarto = Quarto};
            }
            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].ToString());
                }
            }

        }
    }
}

