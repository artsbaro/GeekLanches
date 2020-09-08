
using System;

namespace GeekLanches.Domain.Entities
{
    public class Ingrediente : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        /// <summary>
        /// Aplica o percentual de Inflação no Ingrediente
        /// </summary>
        /// <param name="percentualInflacao"></param>
        public void AplicarInflacao(decimal percentualInflacao)
        {
            Valor = (1 + percentualInflacao) * Valor;
        }
    }
}
