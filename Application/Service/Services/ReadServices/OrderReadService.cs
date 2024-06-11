using Application.Query.OrderQueries.GetOrder;
using Application.Service.IServices.IReadServices;
using Domain.Repositories.OrderRepositories;
using InfraStucture.Repositories.ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.ReadServices
{
    public class OrderReadService : IOrderReadService
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IDapperUnitOfWork _unitOfWork;
        public OrderReadService(IOrderReadRepository orderReadRepository, IDapperUnitOfWork unitOfWork) { 
            _orderReadRepository = orderReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<GetOrderQueryResponse> GetOrderByIdAsync(int id)
        {
            var order = await _orderReadRepository.GetByIdAsync(id);
            var result = new GetOrderQueryResponse
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                Customer = order.Customer,
                OrderItems = order.OrderItems,
            };
            return result;
        }

        public async Task<IEnumerable<GetOrderQueryResponse>> GetOrdersAsync()
        {
            var orders = await _orderReadRepository.GetAllAsync();
            var result = orders.Select(order => new GetOrderQueryResponse
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                Customer = order.Customer,
                OrderItems = order.OrderItems,
            }).ToList();

            return result;
        }
    }
}
