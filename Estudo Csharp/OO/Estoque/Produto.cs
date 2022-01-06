using System;
using System.Globalization;

namespace Estudo_Csharp.OO.Estoque
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        private Produto(int quantidade)
        {
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco, int quantidade) : this(quantidade)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Dados do produto: "
                + Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
