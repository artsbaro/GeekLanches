using GeekLanches.Application.Dtos.Ingrediente;
using System;

namespace GeekLanches.Application.Dtos.Lanche
{
    public class LancheIngredienteDto
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime? DataUltimaAlteracao { get; set; }
        public virtual bool Ativo { get; set; }
        public Guid IdLanche { get; set; }
        public Guid IdIngrediente { get; set; }
        public byte QtdeIngredientes { get; set; }
        public IngredienteDto Ingrediente { get; set; }
        public LancheDto Lanche { get; set; }
    }
}
