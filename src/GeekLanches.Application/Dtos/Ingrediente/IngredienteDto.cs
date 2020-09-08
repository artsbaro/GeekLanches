using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GeekLanches.Application.Dtos.Ingrediente
{
    public class IngredienteDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(100, ErrorMessage = "Nome deve ter menos que 100 caracteres")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor não preenchido.")]
        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("Data de cadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Última alteração")]
        public DateTime? DataUltimaAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
