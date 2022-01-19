using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1048
    {
        public static void x(String[] args)
        {
            static void x(string[] args)
            {
                double salarioAntigo, novoSalario, reajusteGanho, porcentual;

                salarioAntigo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (salarioAntigo == 0 || salarioAntigo <= 400.00)
                {
                    reajusteGanho = (15.0 / 100) * salarioAntigo;
                    novoSalario = salarioAntigo + reajusteGanho;
                    porcentual = 15;
                }
                else if (salarioAntigo == 400.01 || salarioAntigo <= 800.00)
                {
                    reajusteGanho = (12.0 / 100) * salarioAntigo;
                    novoSalario = salarioAntigo + reajusteGanho;
                    porcentual = 12;
                }
                else if (salarioAntigo == 800.01 || salarioAntigo <= 1200.00)
                {
                    reajusteGanho = (10.0 / 100) * salarioAntigo;
                    novoSalario = salarioAntigo + reajusteGanho;
                    porcentual = 10;
                }
                else if (salarioAntigo == 1200.01 || salarioAntigo <= 2000.00)
                {
                    reajusteGanho = (7.0 / 100) * salarioAntigo;
                    novoSalario = salarioAntigo + reajusteGanho;
                    porcentual = 7;
                }
                else
                {
                    reajusteGanho = (4.0 / 100) * salarioAntigo;
                    novoSalario = salarioAntigo + reajusteGanho;
                    porcentual = 4;
                }

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture) + ("\n") +
                      "Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture) + ("\n") +
                      "Em percentual: " + porcentual + " %");
            }
        }
    }
}

//simplificar
