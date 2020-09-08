using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Interfaces.Repositories;
using GeekLanches.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace GeekLanches.Domain.Services
{
    public class LancheIngredientesDomainService : ILancheIngredientesDomainService
    {
        private readonly ILancheIngredientesRepository _repository;

        public LancheIngredientesDomainService(ILancheIngredientesRepository repository)
        {
            _repository = repository;
        }


        public void Create(LancheIngrediente entity)
        {
            _repository.Create(entity);
        }

        public LancheIngrediente FindById(Guid id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<LancheIngrediente> FindByLancheId(Guid lancheId)
        {
            return _repository.FindByLancheId(lancheId);
        }

        public IEnumerable<LancheIngrediente> List(string filter)
        {
            return _repository.List(filter);
        }

        public void Update(LancheIngrediente entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            _repository.Update(entity);
        }
    }
}
