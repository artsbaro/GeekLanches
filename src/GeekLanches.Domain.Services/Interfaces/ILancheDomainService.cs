using GeekLanches.Domain.Entities;
using System;
using System.Collections.Generic;

namespace GeekLanches.Domain.Services.Interfaces
{
    public interface ILancheDomainService
    {
        void Create(Lanche entity);
        void Update(Lanche entity);
        IEnumerable<Lanche> List(string filter);
        Lanche FindById(Guid id);
    }
}
