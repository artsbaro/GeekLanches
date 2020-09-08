using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GeekLanches.Application.Dtos.Ingrediente
{
    public class IngredienteInsertDto
    {
        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(128, ErrorMessage = "Nome deve ter menos que 128 caracteres")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor não preenchido.")]
        [DisplayName("Valor")]
        public decimal Valor { get; set; }
    }
}
