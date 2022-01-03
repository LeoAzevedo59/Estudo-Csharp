using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1014
    {
        public static void X(String[] args)
        {
            int DistPercorrida;
            double CombLitro, KmPL;

            DistPercorrida = int.Parse(Console.ReadLine());
            CombLitro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            KmPL = DistPercorrida / CombLitro;

            Console.WriteLine(KmPL.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}


/*
 Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
 */