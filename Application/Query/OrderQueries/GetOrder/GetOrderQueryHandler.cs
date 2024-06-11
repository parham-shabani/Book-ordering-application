using Application.Service.IServices.IReadServices;
using Domain.Entity;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderQueries.GetOrder
{
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, GetOrderQueryResponse>
    {
        private IOrderReadService _orderReadService;
        public GetOrderQueryHandler(IOrderReadService orderReadService)
        {
            _orderReadService = orderReadService;
        }
        public async Task<GetOrderQueryResponse> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderReadService.GetOrderByIdAsync(request.Id);
            return result;
        }
    }
}
