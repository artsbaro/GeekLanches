using System;

namespace GeekLanches.Domain.Entities
{
    public class PromocaoIngrediente : BaseEntity
    {
        public Guid IdPromocao { get; set; }
        public Guid IdIngrediente { get; set; }
        public byte Quantidade { get; set; }
        public decimal PercentualDesconto { get; set; }
    }
}
