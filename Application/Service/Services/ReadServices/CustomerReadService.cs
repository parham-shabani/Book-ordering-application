using Application.Query.CustomerQueries.GetCustomer;
using Application.Service.IServices.IReadServices;
using Domain.Repositories.BookRepositories;
using Domain.Repositories.CustomerRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.ReadServices
{
    public class CustomerReadService : ICustomerReadService
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IDapperUnitOfWork _unitOfWork;
        public CustomerReadService(ICustomerReadRepository customerReadRepository, IDapperUnitOfWork unitOfWork)
        {
            _customerReadRepository = customerReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<GetCustomerQueryResponse> GetCustomerByIdAsync(int id)
        {
            var customer = await _customerReadRepository.GetByIdAsync(id);
            var result = new GetCustomerQueryResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Phone = customer.Phone,
            };
            return result;
        }

        public async Task<IEnumerable<GetCustomerQueryResponse>> GetCustomersAsync()
        {
            var customers = await _customerReadRepository.GetAllCustomersAsync();
            var result = customers.Select(customer => new GetCustomerQueryResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Phone = customer.Phone,
            }).ToList();

            return result;
        }

    }
}
