using Domain.Entity;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Persistance.Dapper;
using InfraStucture.Persistance.EntityFramework;
using InfraStucture.Repositories.ReadRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStucture.Repositories.WriteRepository
{
    public class OrderItemWriteRepository : IOrderItemWriteRepository
    {
        private readonly EFContext _eFContext;

        public OrderItemWriteRepository(EFContext eFContext)
        {
            _eFContext = eFContext;
        }


        public async Task AddAsync(OrderItem orderItem)
        {
            await _eFContext.OrderItem.AddAsync(orderItem);
        }

        public async Task UpdateAsync(OrderItem orderItem)
        {
            _eFContext.OrderItem.Update(orderItem);
        }

        public async Task DeleteAsync(int id)
        {
            var order = await _eFContext.OrderItem.Where(o => o.Id == id).FirstAsync();
            _eFContext.OrderItem.Remove(order);
        }
    }
}
