using Application.Command.CustomerCommands.CreateCustomer;
using Application.Command.CustomerCommands.UpdateCustomer;
using Application.Command.OrderItemCommands.CreateOrderItem;
using Application.Command.OrderItemCommands.UpdateOrderItem;
using Application.Service.IServices.IWriteServices;
using Domain.Entity;
using Domain.Repositories.CustomerRepositories;
using InfraStucture.Repositories.ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.WriteServices
{
    public class OrderItemWriteService : IOrderItemWriteService
    {
        private IEFUnitOfWork _unitOfWork;
        //private readonly IOrderItemWriteRepository _orderItemWriteRepository;
        public OrderItemWriteService(IEFUnitOfWork unitOfWork, IOrderItemWriteRepository orderItemWriteRepository)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(CreateOrderItemCommand request)
        {
            var orderItem = new OrderItem
            {
                Id = request.Id,
                TotalPrice = request.TotalPrice,
                Quantity = request.Quantity,
                BookId = request.BookId,
            };
            await _unitOfWork.OrderItemWriteRepository.AddAsync(orderItem);
            await _unitOfWork.Complete();
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _unitOfWork.OrderItemWriteRepository.DeleteAsync(id);
            await _unitOfWork.Complete();
        }

        public async Task UpdateAsync(UpdateOrderItemCommand request)
        {
            var orderItem = new OrderItem
            {
                Id = request.orderItem.Id,
                BookId = request.orderItem.BookId,
                Quantity = request.orderItem.Quantity,
                TotalPrice = request.orderItem.TotalPrice,
            };
            await _unitOfWork.OrderItemWriteRepository.UpdateAsync(orderItem);
            await _unitOfWork.Complete();
        }
    }
}
