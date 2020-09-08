using GeekLanches.Domain.Entities;
using System;
using System.Collections.Generic;

namespace GeekLanches.Domain.Interfaces.Repositories
{
    public interface ILancheIngredientesRepository : IRepository<LancheIngrediente, string>
    {
        IEnumerable<LancheIngrediente> FindByLancheId(Guid lancheId);

    }
}
