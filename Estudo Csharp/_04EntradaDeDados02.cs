using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class _04EntradaDeDados02
    {
        public static void X(String [] arg)
        {
            int idade;
            char sexo;
            double altura;
            string nome;

            string[] vet = Console.ReadLine().Split(' ');
            
            nome = vet[0];
            sexo = char.Parse(vet[1]);
            idade = int.Parse(vet[2]);
            altura = double.Parse(vet[3],CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
