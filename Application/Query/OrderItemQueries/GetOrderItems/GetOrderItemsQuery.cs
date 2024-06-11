
using Application.Query.OrderItemQueries.GetOrderItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderItemQueries.GetOrderItems
{
    public record GetOrderItemsQuery : IRequest<IEnumerable<GetOrderItemQueryResponse>>
    {

    }
}
