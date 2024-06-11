using Dapper;
using Domain.Entity;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Persistance.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStucture.Repositories.ReadRepository
{
    public class OrderReadRepository : IOrderReadRepository
    {
        private readonly DapperContext _dataBaseContext;
        public OrderReadRepository(DapperContext dataBaseContext) {
            _dataBaseContext = dataBaseContext;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            try
            {
                const string query = "SELECT * FROM [Order]";
                var orders = await _dataBaseContext.connection.QueryAsync<Order>(query, transaction: _dataBaseContext.transaction);
                return orders;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                _dataBaseContext.Dispose();
            }
            return new List<Order>();
        }

        public async Task<Order> GetByIdAsync(int orderId)
        {
            try
            {
                const string query = "SELECT * FROM [Order] WHERE Id = @orderId";
                var order = await _dataBaseContext.connection.QuerySingleOrDefaultAsync<Order>(query, new { OrderId = orderId }, transaction: _dataBaseContext.transaction);

                return order;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally { _dataBaseContext.Dispose(); }
            return new Order();
        }
    }
}
