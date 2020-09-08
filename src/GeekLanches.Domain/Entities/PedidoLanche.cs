using System;

namespace GeekLanches.Domain.Entities
{
    public class PedidoLanche : BaseEntity
    {
        public Guid IdLanche { get; set; }
        public Guid IdPedido { get; set; }
        public byte QtdeLanches { get; set; }
        public bool Personalizado { get; set; }
        public Lanche Lanche { get; set; }
    }
}
