using Dapper;
using Domain.Entity;
using Domain.Repositories.CustomerRepositories;
using InfraStucture.Persistance.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStucture.Repositories.ReadRepository
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        private readonly DapperContext _dataBaseContext;
        public CustomerReadRepository(DapperContext dapperContext) {
            _dataBaseContext = dapperContext;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            try
            {
                const string query = "SELECT * FROM Customer";
                return await _dataBaseContext.connection.QueryAsync<Customer>(query, transaction: _dataBaseContext.transaction);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                _dataBaseContext.Dispose();
            }
            return new List<Customer>();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            try
            {
                string query = "SELECT Id, Name, Phone FROM Customer WHERE Id = @Id";
                return await _dataBaseContext.connection.QuerySingleOrDefaultAsync<Customer>(query, new { Id = id }, _dataBaseContext.transaction);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _dataBaseContext.Dispose();
            }
            return new Customer();
        }
    }
}
