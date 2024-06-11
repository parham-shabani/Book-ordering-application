using Domain.Entity;
using Domain.Repositories.CustomerRepositories;
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
    public class CustomerWriteRepository : ICustomerWriteRepository
    {
        private readonly EFContext _eFContext;

        public CustomerWriteRepository(EFContext eFContext) {
            _eFContext = eFContext;
        }

        
        public async Task AddAsync(Customer customer)
        {
            await _eFContext.Customer.AddAsync(customer);
        }

        public async Task UpdateAsync(Customer customer)
        {
            _eFContext.Customer.Update(customer);
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _eFContext.Customer.Where(c => c.Id == id).FirstAsync();
            _eFContext.Customer.Remove(customer);
        }
    }
}
