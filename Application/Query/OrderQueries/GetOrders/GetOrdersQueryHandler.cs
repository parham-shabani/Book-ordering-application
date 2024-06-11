using Application.Query.OrderQueries.GetOrder;
using Application.Service.IServices.IReadServices;
using Domain.Entity;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderQueries.GetOrders
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IEnumerable<GetOrderQueryResponse>>
    {
        private readonly IOrderReadService _orderReadService;
        public GetOrdersQueryHandler(IOrderReadService orderReadService)
        {
           _orderReadService = orderReadService;
        }


        public async Task<IEnumerable<GetOrderQueryResponse>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderReadService.GetOrdersAsync();
            return result;
        }
    }
}
