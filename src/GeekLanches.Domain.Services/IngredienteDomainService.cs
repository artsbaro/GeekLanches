using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Interfaces.Repositories;
using GeekLanches.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace GeekLanches.Domain.Services
{
    public class IngredienteDomainService : IIngredienteDomainService
    {
        private readonly IIngredienteRepository _repository;

        public IngredienteDomainService(IIngredienteRepository repository)
        {
            _repository = repository;
        }

        public void AplicaInflacao(decimal percentual)
        {
            // Com a regra no dominio
            
            //var ingredientes = _repository.List("");
            //foreach (var ingrediente in ingredientes)
            //{
            //    ingrediente.AplicarInflacao(percentual);
            //    Update(ingrediente);
            //}
            
            // OU

            // Com a regra no Banco de dados
            _repository.AplicaInflacao(percentual);
        }

        public void Create(Ingrediente entity)
        {
            _repository.Create(entity);
        }

        public Ingrediente FindById(Guid id)
        {
            return _repository.FindById(id);
        }

        public IEnumerable<Ingrediente> List(string filter)
        {
            return _repository.List(filter);
        }

        public void Update(Ingrediente entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            _repository.Update(entity);
        }
    }
}
