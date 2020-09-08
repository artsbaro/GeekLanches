using GeekLanches.Domain.Entities;
using System;
using System.Collections.Generic;

namespace GeekLanches.Domain.Services.Interfaces
{
    public interface IIngredienteDomainService
    {
        void Create(Ingrediente entity);
        void Update(Ingrediente entity);
        IEnumerable<Ingrediente> List(string filter);
        Ingrediente FindById(Guid id);
        void AplicaInflacao(decimal percentual);
    }
}
