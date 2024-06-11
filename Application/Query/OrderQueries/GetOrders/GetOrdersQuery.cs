using Application.Query.OrderQueries.GetOrder;
using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderQueries.GetOrders
{
    public record GetOrdersQuery : IRequest<IEnumerable<GetOrderQueryResponse>>
    {

    }
}
