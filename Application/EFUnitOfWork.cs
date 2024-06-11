using Domain.Repositories.BookRepositories;
using Domain.Repositories.CustomerRepositories;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Persistance.EntityFramework;
using InfraStucture.Repositories.ReadRepository;
using InfraStucture.Repositories.WriteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class EFUnitOfWork : IEFUnitOfWork
    {
        private readonly EFContext _context;

        public IBookWriteRepository BookWriteRepository { get; private set; }
        public ICustomerWriteRepository CustomerWriteRepository { get; private set; }
        public IOrderWriteRepository OrderWriteRepository { get; private set; }
        public IOrderItemWriteRepository OrderItemWriteRepository { get; private set; }

        public EFUnitOfWork(EFContext context)
        {
            _context = context;

            BookWriteRepository = new BookWriteRepository(_context);
            CustomerWriteRepository = new CustomerWriteRepository(_context);
            OrderWriteRepository = new OrderWriteRepository(_context);
            OrderItemWriteRepository = new OrderItemWriteRepository(_context);
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
