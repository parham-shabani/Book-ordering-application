using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderItemQueries.GetOrderItem
{
    public record GetOrderItemQuery : IRequest<GetOrderItemQueryResponse>
    {
        public int Id { get; set; }
    }
}
