using CadastroPedido.Entidades;
using CadastroPedido.Entidades.Enums;
using System;
using System.Globalization;

namespace CadastroPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DADOS DO CLIENTE:");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("DADOS DO PEDIDO:");
            Console.Write("Status: ");

            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());
            var cliente = new Cliente(nomeCliente, email, dataNasc);
            var pedido = new Pedido(DateTime.Now,status, cliente);

            Console.WriteLine("Quantos itens no pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"DADOS DO ITEM {i}:");
                Console.Write("Nome do Produto: ");
                string nomeProd = Console.ReadLine();
                Console.Write("Preço: R$");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var produto = new Produto(nomeProd, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

               var peditoItens = new PedidoItem(quantidade,preco,produto);

                pedido.addItem(peditoItens);

            }

            Console.WriteLine();
            Console.WriteLine("LISTA DE PEDIDOS");
            Console.WriteLine(pedido);


        }
    }
}
