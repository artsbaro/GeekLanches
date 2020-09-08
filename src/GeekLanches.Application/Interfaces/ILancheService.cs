using GeekLanches.Application.Dtos.Lanche;
using System;
using System.Collections.Generic;

namespace GeekLanches.Application.Interfaces
{
    public interface ILancheService
    {
        void Create(LancheInsertDto dto);
        LancheDto FindById(Guid id);

        /// <summary>
        /// filter = string nome
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IEnumerable<LancheDto> List(string filter);
        void Update(LancheDto dto);
    }
}
