using Dapper;
using Domain.Entity;
using Domain.Repositories.OrderItemRepositories;
using InfraStucture.Persistance.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStucture.Repositories.ReadRepository
{
    public class OrderItemReadRepository : IOrderItemReadRepository
    {
        private readonly DapperContext dataBaseContext;

        public OrderItemReadRepository(DapperContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public async Task<IEnumerable<OrderItem>> GetAllAsync()
        {
            try
            {
                const string query = "SELECT * FROM OrderItem";
                var orderItems = await dataBaseContext.connection.QueryAsync<OrderItem>(query, transaction: dataBaseContext.transaction);
                return orderItems;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dataBaseContext.Dispose();
            }
            return new List<OrderItem>();
        }

        public async Task<OrderItem> GetByIdAsync(int id)
        {
            try
            {
                const string query = "SELECT * FROM OrderItem WHERE Id = @id";
                var orderItem = await dataBaseContext.connection.QuerySingleOrDefaultAsync<OrderItem>(query, new { id }, transaction: dataBaseContext.transaction);
                return orderItem;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { dataBaseContext.Dispose(); }
            return new OrderItem();
        }
    }
}
