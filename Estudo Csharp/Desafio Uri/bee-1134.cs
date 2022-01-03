using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1134
    {
        public static void X(String[] args)
        {

            int X, Alcool, Gasolina, Diesel, Fim;

            Alcool = 0;
            Gasolina = 0;
            Diesel = 0;
            Fim = 0;

            X = int.Parse(Console.ReadLine());                                                                                                        

            while (X != 4)
            {

                if (X > 0 && X < 5)
                {
                    switch (X)
                    {
                        case (1):
                            Alcool += 1;
                            break;
                        case (2):
                            Gasolina += 1;
                            break;
                        case (3):
                            Diesel += 1;
                            break;
                        default:
                            break;
                    }
                }

                X = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);
        }
    }
}
