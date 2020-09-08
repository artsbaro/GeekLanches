using System;
using System.Collections.Generic;
using System.Linq;
using GeekLanches.Application.Dtos.Lanche;
using GeekLanches.Application.Interfaces;
using GeekLanches.Application.Mappers.Default;
using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Services.Interfaces;

namespace GeekLanches.Application.Services
{
    public class LancheService : ILancheService
    {
        private readonly ILancheDomainService _service;

        public LancheService(ILancheDomainService service)
        {
            _service = service;
        }

        public void Create(LancheInsertDto dto)
        {
            var objPersistencia = TypeConverter.ConvertTo<Lanche>(dto);
            _service.Create(objPersistencia);
        }

        public LancheDto FindById(Guid id)
        {
            var entidade = _service.FindById(id);
            var dto = new LancheDto {
                Id = entidade.Id,
                Nome = entidade.Nome,
                Ativo = entidade.Ativo,
                DataCadastro = entidade.DataCadastro,
                DataUltimaAlteracao = entidade.DataUltimaAlteracao,
                LancheIngredientes = entidade.LancheIngredientes.Select(l => new LancheIngredienteDto { 
                    Id = l.Id,
                    Ativo = l.Ativo,
                    DataUltimaAlteracao = l.DataUltimaAlteracao,
                    DataCadastro = l.DataCadastro,
                    IdIngrediente = l.IdIngrediente,
                    IdLanche = l.IdLanche,
                    QtdeIngredientes = l.QtdeIngredientes,
                    Ingrediente = new Dtos.Ingrediente.IngredienteDto { 
                        Id = l.Ingrediente.Id,
                        Nome = l.Ingrediente.Nome,
                        Ativo = l.Ingrediente.Ativo,
                        Valor = l.Ingrediente.Valor,
                        DataCadastro = l.Ingrediente.DataCadastro,
                        DataUltimaAlteracao = l.Ingrediente.DataUltimaAlteracao
                    }
                })
            };

            return dto;
        }

        public IEnumerable<LancheDto> List(string filter)
        {
            var list = _service.List(filter);
            return TypeConverter.ConvertTo<IEnumerable<LancheDto>>(list);
        }

        public void Update(LancheDto dto)
        {
            _service.Update(TypeConverter.ConvertTo<Lanche>(dto));
        }
    }
}