using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estudo_Csharp
{
    class bee_1021
    {
        public static void X(String[] args)
        {
            //notas
            int Real, Centavos, Cem, Cinquenta, Vinte, Dez, Cinco, Dois,
                RestoCem, RestoCinquenta, RestoVinte, RestoDez, RestoCinco, RestoDois,

                //moedas
                UmReal, CinquentaC, VinteCincoC, DezC, CincoC, UmC,
                RestoCinquentaC, RestoVinteCincoC, RestoDezC, RestoCincoC;



            string[] vet = Console.ReadLine().Split(".");

            Real = int.Parse(vet[0]);
            Centavos = int.Parse(vet[1]);

            //notas
            Cem = Real / 100;
            RestoCem = Real % 100;

            Cinquenta = RestoCem / 50;
            RestoCinquenta = RestoCem % 50;

            Vinte = RestoCinquenta / 20;
            RestoVinte = RestoCinquenta % 20;

            Dez = RestoVinte / 10;
            RestoDez = RestoVinte % 10;

            Cinco = RestoDez / 5;
            RestoCinco = RestoDez % 5;

            Dois = RestoCinco / 2;
            RestoDois = RestoCinco % 2;

            //moedas
            UmReal = RestoDois / 1;

            CinquentaC = Centavos / 50;
            RestoCinquentaC = Centavos % 50;

            VinteCincoC = RestoCinquentaC / 25;
            RestoVinteCincoC = RestoCinquentaC % 25;

            DezC = RestoVinteCincoC / 10;
            RestoDezC = RestoVinteCincoC % 10;

            CincoC = RestoDezC / 5;
            RestoCincoC = RestoDezC % 5;

            UmC = RestoCincoC / 1;



            Console.WriteLine("NOTAS:");
            Console.WriteLine(Cem + " nota(s) de R$ 100.00");
            Console.WriteLine(Cinquenta + " nota(s) de R$ 50.00");
            Console.WriteLine(Vinte + " nota(s) de R$ 20.00");
            Console.WriteLine(Dez + " nota(s) de R$ 10.00");
            Console.WriteLine(Cinco + " nota(s) de R$ 5.00");
            Console.WriteLine(Dois + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(UmReal + " moeda(s) de R$ 1.00");
            Console.WriteLine(CinquentaC + " moeda(s) de R$ 0.50");
            Console.WriteLine(VinteCincoC + " moeda(s) de R$ 0.25");
            Console.WriteLine(DezC + " moeda(s) de R$ 0.10");
            Console.WriteLine(CincoC + " moeda(s) de R$ 0.05");
            Console.WriteLine(UmC + " moeda(s) de R$ 0.01");
        }
    }
}

/*
 Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.
 */