using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1015
    {
        public static void X(String[] args)
        {
            double X1, Y1, X2, Y2, Result;

            string[] vet1 = Console.ReadLine().Split(' ');

            X1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            Y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            X2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            Y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            Result = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));

            Console.WriteLine(Result.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}


/*
 Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

Distancia =

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.
 */