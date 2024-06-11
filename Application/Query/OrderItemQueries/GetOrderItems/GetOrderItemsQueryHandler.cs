using Application.Query.CustomerQueries.GetCustomers;
using Application.Query.OrderItemQueries.GetOrderItem;
using Application.Service.IServices.IReadServices;
using Domain.Repositories.OrderItemRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderItemQueries.GetOrderItems
{
    public class GetOrderItemsQueryHandler : IRequestHandler<GetOrderItemsQuery, IEnumerable<GetOrderItemQueryResponse>>
    {
        private readonly IOrderItemReadService _orderItemReadService;
        public GetOrderItemsQueryHandler(IOrderItemReadService orderItemReadService)
        {
            _orderItemReadService = orderItemReadService;
        }


        public async Task<IEnumerable<GetOrderItemQueryResponse>> Handle(GetOrderItemsQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderItemReadService.GetOrderItemsAsync();
            return result;
        }
    }
}
