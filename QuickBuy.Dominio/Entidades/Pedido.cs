using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um pedido
        /// ou muitos pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedidos { get; set; }
    }
}
