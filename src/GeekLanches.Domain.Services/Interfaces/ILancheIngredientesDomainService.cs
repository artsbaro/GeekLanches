using GeekLanches.Domain.Entities;
using System;
using System.Collections.Generic;

namespace GeekLanches.Domain.Services.Interfaces
{
    public interface ILancheIngredientesDomainService
    {
        void Create(LancheIngrediente entity);
        void Update(LancheIngrediente entity);
        IEnumerable<LancheIngrediente> List(string filter);
        LancheIngrediente FindById(Guid id);
        IEnumerable<LancheIngrediente> FindByLancheId(Guid lancheId);
    }
}
