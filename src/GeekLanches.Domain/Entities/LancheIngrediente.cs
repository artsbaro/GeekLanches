using System;

namespace GeekLanches.Domain.Entities
{
    public class LancheIngrediente : BaseEntity
    {
        public Guid IdLanche { get; set; }
        public Guid IdIngrediente { get; set; }
        public byte QtdeIngredientes { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public Lanche Lanche { get; set; }
    }
}
