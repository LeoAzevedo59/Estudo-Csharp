using System;
using System.Globalization;

namespace Estudo_Csharp.OO.Estoque
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        private Produto(int quantidade)
        {
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco, int quantidade) : this(quantidade)
        {
            _nome = nome;
            _preco = preco;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) 
            _nome = nome;
        }

        public double ValorTotalEmEstoque()
        {
            return _quantidade * _preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Dados do produto: "
                + _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
