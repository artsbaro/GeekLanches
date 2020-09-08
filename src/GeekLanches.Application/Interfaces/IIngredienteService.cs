using GeekLanches.Application.Dtos.Ingrediente;
using System;
using System.Collections.Generic;

namespace GeekLanches.Application.Interfaces
{
    public interface IIngredienteService
    {
        void Create(IngredienteInsertDto dto);
        IngredienteDto FindById(Guid id);

        /// <summary>
        /// filter = string nome
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IEnumerable<IngredienteDto> List(string filter);
        void Update(IngredienteDto dto);
        void AplicaInflacao(decimal percentual);
    }
}
