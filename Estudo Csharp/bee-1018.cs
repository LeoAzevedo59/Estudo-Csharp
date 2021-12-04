using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp
{
    class bee_1018
    {
        public static void X(String[] args)
        {
            int ValorBruto, cem, cinquenta, vinte, dez, cinco, dois, um,
                            CemResto, CinquentaResto, VinteResto,  DezResto, CincoResto, DoisResto;

            ValorBruto = int.Parse(Console.ReadLine());

            cem = ValorBruto / 100;
            CemResto = ValorBruto % 100;

            cinquenta = CemResto / 50;
            CinquentaResto = CemResto % 50;

            vinte = CinquentaResto / 20;
            VinteResto = CinquentaResto % 20;

            dez = VinteResto / 10;
            DezResto = VinteResto % 10;

            cinco = DezResto / 5;
            CincoResto = DezResto % 5;

            dois = CincoResto / 2;
            DoisResto = CincoResto % 2;

            um = DoisResto / 1;



            Console.WriteLine(ValorBruto);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez+ " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");



        }
    }
}