using Dapper;
using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace GeekLanches.Infra.Data.Repository
{
    public class LancheRepository : RepositoryBase, ILancheRepository
    {
        public LancheRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Create(Lanche entity)
        {
            Connection.Execute(
                "SProc_Lanche_Insert",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Nome,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }


        public Lanche FindById(Guid id)
        {
            return Connection.QueryFirstOrDefault<Lanche>(
               "SProc_Lanche_GetById",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public IEnumerable<Lanche> List(string filter)
        {
            return Connection.Query<Lanche>(
               "SProc_Lanches_GetByFilter",
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

        public void Update(Lanche entity)
        {
            Connection.Execute(
                "SProc_Lanche_Update",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Nome,
                    entity.Ativo,
                    entity.DataUltimaAlteracao
                }
            );
        }
    }
}
