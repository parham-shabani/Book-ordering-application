using Application.Command.CustomerCommands.CreateCustomer;
using Application.Command.CustomerCommands.UpdateCustomer;
using Application.Command.OrderCommands.CreateOrder;
using Application.Command.OrderCommands.UpdateOrder;
using Application.Service.IServices.IWriteServices;
using Domain.Entity;
using Domain.Repositories.CustomerRepositories;
using Domain.Repositories.OrderRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.WriteServices
{
    public class OrderWriteService : IOrderWriteService
    {
        private IEFUnitOfWork _unitOfWork;
        //private readonly IOrderWriteRepository _orderWriteRepository;
        public OrderWriteService(IEFUnitOfWork unitOfWork, IOrderWriteRepository orderWriteRepository)
        {
            _unitOfWork = unitOfWork;

        }

        public async Task AddAsync(CreateOrderCommand request)
        {
            var order = new Order
            {
                Id = request.Id,
                OrderDate = request.OrderDate,
                OrderItems = request.OrderItems,
                Customer = request.Customer,
            };
            await _unitOfWork.OrderWriteRepository.AddAsync(order);
            await _unitOfWork.Complete();
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _unitOfWork.OrderWriteRepository.DeleteAsync(id);
            await _unitOfWork.Complete();
        }

        public async Task UpdateAsync(UpdateOrderCommand request)
        {
            var order = new Order
            {
                Id = request.id,
                OrderDate = request.order.orderDate,
                OrderItems = request.order.OrderId,
                Customer = request.order.customer,
            };
            await _unitOfWork.OrderWriteRepository.UpdateAsync(order);
            await _unitOfWork.Complete();
        }
    }
}
