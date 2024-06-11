using Application.Command.CustomerCommands.CreateCustomer;
using Application.Command.CustomerCommands.UpdateCustomer;
using Application.Service.IServices.IWriteServices;
using Domain.Entity;
using Domain.Repositories.CustomerRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.WriteServices
{
    public class CustomerWriteService : ICustomerWriteService
    {
        private IEFUnitOfWork _unitOfWork;
        //private readonly ICustomerWriteRepository _customerWriteRepository;
        public CustomerWriteService(IEFUnitOfWork unitOfWork, ICustomerWriteRepository customerWriteRepository)
        {
            _unitOfWork = unitOfWork;
           
        }

        public async Task AddAsync(CreateCustomerCommand request)
        {
            var customer = new Customer
            {
                Id = request.Id,
                Name = request.Name,
                Phone = request.Phone,
            };   
            await _unitOfWork.CustomerWriteRepository.AddAsync(customer);
            await _unitOfWork.Complete();
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _unitOfWork.CustomerWriteRepository.DeleteAsync(id);   
            await _unitOfWork.Complete();
        }

        public async Task UpdateAsync(UpdateCustomerCommand request)
        {
            var customer = new Customer
            {
                Id = request.customer.id,
                Name = request.customer.Name,
                Phone = request.customer.Phone,
            };
            await _unitOfWork.CustomerWriteRepository.UpdateAsync(customer);
            await _unitOfWork.Complete(); 
        }
    }
}
