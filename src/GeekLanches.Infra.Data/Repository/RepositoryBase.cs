using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace GeekLanches.Infra.Data.Repository
{
    public abstract class RepositoryBase
    {
        internal const string CONNECTIONSTRING_KEY = "DefaultConnection";

        internal IDbConnection Connection { get; set; }

        protected RepositoryBase(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString(CONNECTIONSTRING_KEY);
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(connectionString, "Connection string not found");
            Connection = new SqlConnection(connectionString);
        }

        public IDbTransaction Transaction { get; private set; }



        public void SetTransaction(IDbTransaction transaction)
        {
            Transaction = transaction;
            Connection = transaction.Connection;
        }

        internal void SetConnection(IDbConnection connection)
        {
            Connection = connection;
            Transaction = null;
        }
    }
}
