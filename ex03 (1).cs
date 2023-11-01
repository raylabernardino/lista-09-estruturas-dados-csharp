//Você foi contratado para desenvolver um programa em C# para criar um sistema de carrinho de compras usando HashTables.
//O programa permite adicionar produtos ao carrinho, visualizar o carrinho,
//finalizar a compra mostrando o valor total a ser pago e sair.
//Cada produto é representado pelo seu nome (chave) e preço (valor associado) na HashTable.
using System;
using System.Collections.Generic;

class HelloWorld
{
    static void Main()
    {
        Produtos pd = new Produtos();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar produto");
            Console.WriteLine("2. Exibir lista de produtos");
            Console.WriteLine("3. Finalizar venda");
            Console.WriteLine("4. Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Produto: ");
                    pd.produto = Console.ReadLine();
                    Console.WriteLine("Valor: ");
                    pd.valor = decimal.Parse(Console.ReadLine());

                    pd.AdicionarCarrinho();
                    break;

                case "2":
                    pd.ExibirCarrinho();
                    break;

                case "3":
                    pd.TotalPagar();
                    break;

                case "4":
                    Console.WriteLine("Encerrando ...\n");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    break;
            }
        }

    }
}