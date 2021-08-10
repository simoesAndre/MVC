using System.Collections.Generic;

namespace Atividade_02.Models
{
    public class Pedido
    {
        private static List<ItemPedido> lista = new List<ItemPedido>();

        public static void Incluir(ItemPedido PedidoAtual)
        {
            lista.Add(PedidoAtual);
        }

        public static List<ItemPedido> Listar()
        {
            return lista;
        }
    }
}
