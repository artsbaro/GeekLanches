using System.Collections.Generic;

namespace GeekLanches.Domain.Entities
{
    public class Lanche : BaseEntity
    {
        public string Nome { get; set; }
        public IEnumerable<LancheIngrediente> LancheIngredientes { get; set; }        
    }
}
