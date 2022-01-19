﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Calculadora
{
    class Calculadora
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Trip(ref int x)
        {
            x = x * 3;
        }

        public static void Trip1(int orign, out int result)
        {
            result = orign * 3;
        }
    }
}
