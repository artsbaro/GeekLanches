using System.Collections.Generic;

namespace GeekLanches.Domain.Entities
{
    public class Pedido : BaseEntity
    {
        public decimal Subtotal { get; set; }

        public decimal Desconto { get; set; }

        public decimal Total { get; set; }

        public IEnumerable<PedidoLanche> PedidoLanches { get; set; }

        /// <summary>
        /// Aplica o percentual de Desconto no subtotal
        /// </summary>
        /// <param name="percentualDesconto"></param>
        public void AplicarDesconto(decimal percentualDesconto)
        {
            Desconto = Subtotal * percentualDesconto;
            Total = Subtotal - Desconto;
        }
    }
}
