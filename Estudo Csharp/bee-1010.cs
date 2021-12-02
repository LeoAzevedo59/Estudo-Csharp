using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1010
    {
        public static void X(String[] args)
        {
            int IdPeca, IdPeca2, Qtde, Qtde2;
            double ValorUni, ValorUni2, ValorTotal;

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            IdPeca = int.Parse(vet[0]);
            Qtde = int.Parse(vet[1]);
            ValorUni = double.Parse(vet[2], CultureInfo.InvariantCulture);

            IdPeca2 = int.Parse(vet2[0]);
            Qtde2 = int.Parse(vet2[1]);
            ValorUni2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            ValorTotal = (Qtde * ValorUni) + (Qtde2 * ValorUni2);

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

/*
 Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
 */
