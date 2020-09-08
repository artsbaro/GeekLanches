using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GeekLanches.Application.Dtos.Lanche
{
    public class LancheDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(100, ErrorMessage = "Nome deve ter menos que 100 caracteres")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Data de cadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Última alteração")]
        public DateTime? DataUltimaAlteracao { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<LancheIngredienteDto> LancheIngredientes { get; set; }

        public Guid IngredienteId { get; set; }

        public string IngredienteNome { get; set; }

        public byte IngredienteQuantidade { get; set; }
    }
}
