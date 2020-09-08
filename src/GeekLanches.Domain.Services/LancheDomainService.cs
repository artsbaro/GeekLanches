using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Interfaces.Repositories;
using GeekLanches.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace GeekLanches.Domain.Services
{
    public class LancheDomainService : ILancheDomainService
    {
        private readonly ILancheRepository _repository;
        private readonly ILancheIngredientesRepository _lancheIngredientesRepository;
        private readonly IIngredienteRepository _ingredienteRepository;

        public LancheDomainService(ILancheRepository repository,
            ILancheIngredientesRepository lancheIngredientesRepository,
            IIngredienteRepository ingredienteRepository)
        {
            _repository = repository;
            _lancheIngredientesRepository = lancheIngredientesRepository;
            _ingredienteRepository = ingredienteRepository;
        }

        public void Create(Lanche entity)
        {
            _repository.Create(entity);
        }

        public Lanche FindById(Guid id)
        {
            var lanche = _repository.FindById(id);

            if (lanche != null)
            { 
                lanche.LancheIngredientes = _lancheIngredientesRepository.FindByLancheId(id);

                foreach (var lancheIngrediente in lanche.LancheIngredientes)
                {
                    lancheIngrediente.Ingrediente = _ingredienteRepository.FindById(lancheIngrediente.IdIngrediente);
                    lancheIngrediente.Lanche = lanche;
                }
            }

            return lanche;
        }

        public IEnumerable<Lanche> List(string filter)
        {
            return _repository.List(filter);
        }

        public void Update(Lanche entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            _repository.Update(entity);
        }
    }
}
