using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO.Quartos
{
    class Cadastro
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }

    }

}
