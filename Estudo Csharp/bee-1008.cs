using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1008
    {
        public static void X(String[] args)
        {
            int idFuncionario, HorasTrabalhadas;
            double ValorPorHora, Salario;

            idFuncionario = int.Parse(Console.ReadLine());
            HorasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ValorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Salario = HorasTrabalhadas * ValorPorHora;

            Console.WriteLine("NUMBER = " + idFuncionario);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

/*
 Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Entrada
O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

Saída
Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.
 */
