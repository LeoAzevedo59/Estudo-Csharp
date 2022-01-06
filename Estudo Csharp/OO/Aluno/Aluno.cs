using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Aluno
{
    class Aluno
    {
        public double A;
        public double B;
        public double C;

        public double NotaFinal()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            double Nota = NotaFinal();

            if (Nota >= 60)
                return "APROVADO";
            else
            { 
                return "REPROVADO" + "\n" + "FALTARAM " + Restante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }

        public double Restante()
        {
            double nota = NotaFinal();
            double resto = 60.0 - nota;
            return resto;
        }
    }
}
