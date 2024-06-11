using Domain.Entity;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Persistance.Dapper;
using InfraStucture.Persistance.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStucture.Repositories.WriteRepository
{
    public class OrderWriteRepository : IOrderWriteRepository
    {
        private readonly EFContext _eFContext;

        public DapperContext DataBaseContext { get; }

        public OrderWriteRepository(EFContext eFContext)
        {
            _eFContext = eFContext;
        }


        public async Task AddAsync(Order order)
        {
            await _eFContext.Order.AddAsync(order);
        }

        public async Task UpdateAsync(Order order)
        {
            _eFContext.Order.Update(order);
        }

        public async Task DeleteAsync(int id)
        {
            var order = await _eFContext.Order.Where(o => o.Id == id).FirstAsync();
            _eFContext.Order.Remove(order);
        }
    }
}
