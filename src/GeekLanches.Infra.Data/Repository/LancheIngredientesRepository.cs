using Dapper;
using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace GeekLanches.Infra.Data.Repository
{
    public class LancheIngredientesRepository : RepositoryBase, ILancheIngredientesRepository
    {
        public LancheIngredientesRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Create(LancheIngrediente entity)
        {
            Connection.Execute(
                "SProc_LancheIngredientes_Insert",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.IdLanche,
                    entity.IdIngrediente,
                    entity.QtdeIngredientes,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }

        public LancheIngrediente FindById(Guid id)
        {
            return Connection.QueryFirstOrDefault<LancheIngrediente>(
               "SProc_LancheIngredientes_GetById",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public IEnumerable<LancheIngrediente> FindByLancheId(Guid lancheId)
        {
            return Connection.Query<LancheIngrediente>(
               "SProc_LancheIngredientes_GetByIdLanche",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    IdLanche = lancheId
                });
        }

        public IEnumerable<LancheIngrediente> List(string filter)
        {
            return Connection.Query<LancheIngrediente>(
               "SProc_LancheIngredientes_GetByFilter",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    Nome = filter
                });
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(LancheIngrediente entity)
        {
            Connection.Execute(
                "SProc_LancheIngredientes_Update",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.IdLanche,
                    entity.IdIngrediente,
                    entity.QtdeIngredientes,
                    entity.Ativo,
                    entity.DataUltimaAlteracao
                }
            );
        }
    }
}
