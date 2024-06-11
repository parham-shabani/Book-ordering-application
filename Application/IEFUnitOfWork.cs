using Domain.Repositories.BookRepositories;
using Domain.Repositories.CustomerRepositories;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Repositories.ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IEFUnitOfWork : IDisposable
    {

        public IBookWriteRepository BookWriteRepository { get; }
        public ICustomerWriteRepository CustomerWriteRepository { get; }
        public IOrderItemWriteRepository OrderItemWriteRepository { get; }
        public IOrderWriteRepository OrderWriteRepository { get; }
        

        Task Complete();
    }
}

