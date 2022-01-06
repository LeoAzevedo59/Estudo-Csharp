using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Aluno
{
    class AppAluno
    {
        static void X(String[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");

            aluno.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno);
            

        }
    }
}
