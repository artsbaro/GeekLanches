using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GeekLanches.Application.Dtos.Lanche
{
    public class LancheInsertDto
    {
        [Required(ErrorMessage = "Nome não preenchido.")]
        [MinLength(3, ErrorMessage = "Nome deve ter mais que 3 caracteres")]
        [MaxLength(100, ErrorMessage = "Nome deve ter menos que 100 caracteres")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

    }
}
