using Estudo_Csharp.OO.Estoque;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Csharp.OO
{
    class ControleDeEstoque
    {
        static void X(String[] args)
        {
            double Total;
            int qte;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            Total = produto.ValorTotalEmEstoque();

            Console.WriteLine(produto);

            Console.WriteLine("Digite um número de produtos a ser adicionado ao estoque:");

            qte = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(qte);

            Total = produto.ValorTotalEmEstoque();

            Console.WriteLine(produto);

            Console.WriteLine("Digite um número de produtos a ser removido ao estoque:");

            qte = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(qte);

            Total = produto.ValorTotalEmEstoque();

            Console.WriteLine(produto);

        }
    }
}
