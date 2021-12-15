using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class _14ConversaoTemperatura
    {
        static void X(String[] args)
        {
            double Celsius, Fahrenheit;
            char opcao;
            opcao = 's';

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                Celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Fahrenheit = (Celsius * 1.8) + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + Fahrenheit.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir (s/n)?");
                opcao = char.Parse(Console.ReadLine());
            } while (opcao == 's');
        }
    }
}
