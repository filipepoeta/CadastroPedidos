using CadastroPedido.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPedido.Entidades
{
    class Pedido
    {
        public DateTime DataDoPedido { get; set; }
        public StatusPedido Status { get; set; }
        public List<PedidoItem> PedidoItems { get; set; } = new List<PedidoItem>();
        public Cliente Cliente { get; set; }

        public Pedido()
        {

        }

        public Pedido(DateTime dataDoPedido, StatusPedido status, Cliente cliente)
        {
            DataDoPedido = dataDoPedido;
            Status = status;
            Cliente = cliente;
        }

        public void addItem(PedidoItem item)
        {
            PedidoItems.Add(item);
        }

        public void removeItem(PedidoItem item) 
        { 
            PedidoItems.Remove(item);
        }

        public double totalPedido()
        {
            double soma = 0;
            foreach(PedidoItem item in PedidoItems)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Data do pedido: {DataDoPedido.ToString("dd/mm/yyyy HH:mm:ss")}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Cliente}");
            sb.AppendLine("Itens do pedido:");
            foreach(PedidoItem item in PedidoItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Valor total R$:{totalPedido().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }

    }
}
