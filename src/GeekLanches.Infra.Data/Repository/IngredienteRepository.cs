using Dapper;
using GeekLanches.Domain.Entities;
using GeekLanches.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace GeekLanches.Infra.Data.Repository
{
    public class IngredienteRepository : RepositoryBase, IIngredienteRepository
    {
        public IngredienteRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Create(Ingrediente entity)
        {
            Connection.Execute(
                "SProc_Ingrediente_Insert",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Nome,
                    entity.Valor,
                    entity.Ativo,
                    entity.DataCadastro
                }
            );
        }


        public Ingrediente FindById(Guid id)
        {
            return Connection.QueryFirstOrDefault<Ingrediente>(
               "SProc_Ingrediente_GetById",
               commandType: CommandType.StoredProcedure,
                param: new
                {
                    Id = id
                }
            );
        }

        public IEnumerable<Ingrediente> List(string filter)
        {
            return Connection.Query<Ingrediente>(
               "SProc_Ingredientes_GetByFilter",
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

        public void Update(Ingrediente entity)
        {
            Connection.Execute(
                "SProc_Ingrediente_Update",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    entity.Id,
                    entity.Nome,
                    entity.Valor,
                    entity.Ativo,
                    entity.DataUltimaAlteracao
                }
            );
        }

        public void AplicaInflacao(decimal percentual)
        {
            Connection.Execute(
                "SProc_Ingredientes_AplicaInflacao",
                commandType: CommandType.StoredProcedure,
                param: new
                {
                    percentual,
                    DataUltimaAlteracao = DateTime.Now
                }
            );
        }
    }
}
