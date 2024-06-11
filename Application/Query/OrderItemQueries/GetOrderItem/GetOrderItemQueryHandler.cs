using Application.Service.IServices.IReadServices;
using Domain.Entity;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderItemQueries.GetOrderItem
{
    public class GetOrderItemQueryHandler : IRequestHandler<GetOrderItemQuery, GetOrderItemQueryResponse>
    {
        private readonly IOrderItemReadService _orderItemReadService;
        public GetOrderItemQueryHandler(IOrderItemReadService orderItemReadService)
        {
            _orderItemReadService = orderItemReadService;
        }

        public async Task<GetOrderItemQueryResponse> Handle(GetOrderItemQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderItemReadService.GetOrderItemByIdAsync(request.Id);
            return result;
        }
    }
}
