using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace InfraStucture.Persistance.Dapper
{
    public class DapperContext
    {
        private bool _disposed = false;
        private IDbTransaction _transaction;

        public IDbConnection connection { get; private set; }
        public IDbTransaction transaction {  get; set; }
        public string ConnectionString { get; private set; }

        private IConfiguration _configuration;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("MyDatabaseConnection");
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _transaction?.Dispose();
                    connection?.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}