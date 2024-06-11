using Application.Query.CustomerQueries.GetCustomer;
using Application.Query.OrderItemQueries.GetOrderItem;
using Application.Service.IServices.IReadServices;
using Domain.Entity;
using Domain.Repositories.CustomerRepositories;
using Domain.Repositories.OrderItemRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.ReadServices
{
    public class OrderItemReadService : IOrderItemReadService
    {
        private readonly IOrderItemReadRepository _orderItemReadRepository;
        private readonly IDapperUnitOfWork _unitOfWork;
        public OrderItemReadService(IOrderItemReadRepository orderItemReadRepository, IDapperUnitOfWork unitOfWork)
        {
            _orderItemReadRepository = orderItemReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<GetOrderItemQueryResponse> GetOrderItemByIdAsync(int id)
        {
            var orderItem = await _orderItemReadRepository.GetByIdAsync(id);
            var result = new GetOrderItemQueryResponse
            {
                Id = orderItem.Id,
                Quantity = orderItem.Quantity,
                BookId = orderItem.BookId,
                TotalPrice = orderItem.TotalPrice,
            };
            return result;
        }

        public async Task<IEnumerable<GetOrderItemQueryResponse>> GetOrderItemsAsync()
        {
            var orderItems = await _orderItemReadRepository.GetAllAsync();
            var result = orderItems.Select(orderItem => new GetOrderItemQueryResponse
            {
                Id = orderItem.Id,
                BookId = orderItem.BookId,
                Quantity = orderItem.Quantity,
                TotalPrice = orderItem.TotalPrice
            }).ToList();

            return result;
        }
    }
}
