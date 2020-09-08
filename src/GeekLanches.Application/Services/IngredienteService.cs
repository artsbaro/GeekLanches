using System;
using System.Collections.Generic;
using GeekLanches.Application.Dtos.Ingrediente;
using GeekLanches.Application.Interfaces;
using GeekLanches.Application.Mappers.Default;
using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Services.Interfaces;

namespace GeekLanches.Application.Services
{
    public class IngredienteService : IIngredienteService
    {
        private readonly IIngredienteDomainService _service;

        public IngredienteService(IIngredienteDomainService service)
        {
            _service = service;
        }

        public void AplicaInflacao(decimal percentual)
        {
            _service.AplicaInflacao(percentual);
        }

        public void Create(IngredienteInsertDto dto)
        {
            var objPersistencia = TypeConverter.ConvertTo<Ingrediente>(dto);
            _service.Create(objPersistencia);
        }

        public IngredienteDto FindById(Guid id)
        {
            var entidade = _service.FindById(id);
            return TypeConverter.ConvertTo<IngredienteDto>(entidade);
        }

        public IEnumerable<IngredienteDto> List(string filter)
        {
            var list = _service.List(filter);
            return TypeConverter.ConvertTo<IEnumerable<IngredienteDto>>(list);
        }

        public void Update(IngredienteDto dto)
        {
            _service.Update(TypeConverter.ConvertTo<Ingrediente>(dto));
        }
    }
}