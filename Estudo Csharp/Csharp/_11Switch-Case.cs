using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _11Switch_Case
    {
        public static void X(String[] args)
        {

            int semana;

            semana = int.Parse(Console.ReadLine());

            switch (semana)
            {
                case 1:
                    Console.WriteLine("Dia Da Semana: Domingo");
                    break;
                case 2:
                    Console.WriteLine("Dia Da Semana: Segunda");
                    break;
                case 3:
                    Console.WriteLine("Dia Da Semana: Terça");
                    break;
                case 4:
                    Console.WriteLine("Dia Da Semana: Quarta");
                    break;
                case 5:
                    Console.WriteLine("Dia Da Semana: Quinta");
                    break;
                case 6:
                    Console.WriteLine("Dia Da Semana: Sexta");
                    break;
                case 7:
                    Console.WriteLine("Dia Da Semana: Sabádo");
                    break;
                default:
                    Console.WriteLine("Dia da semana: valor inválido");
                    break;

            }
        }
    }
}
