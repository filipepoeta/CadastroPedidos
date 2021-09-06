using System.Globalization;
using System.Text;

namespace CadastroPedido.Entidades
{
    class PedidoItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public PedidoItem()
        {

        }

        public PedidoItem(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome do produto: {Produto.Nome}");
            sb.AppendLine($"R$: {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Quantidade: {Quantidade}");
            sb.AppendLine($"Total: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
