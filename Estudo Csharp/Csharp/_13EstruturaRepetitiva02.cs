using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _13EstruturaRepetitiva02
    {
        public static void X(String[] args)
        {
            int idade, soma;
            double x, media;
            idade = 0;
            x = 0;

            soma = 0;

            idade = int.Parse(Console.ReadLine());
            
            if (idade > 0)
            {
                while (idade > 0)
                {

                    soma += idade;
                    x += 1.0;
                    idade = int.Parse(Console.ReadLine());

                }
                media = soma / x;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }


            Console.WriteLine("impossivel calcular");
        }
    }
}
