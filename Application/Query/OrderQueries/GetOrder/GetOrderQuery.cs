using Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderQueries.GetOrder
{
    public record GetOrderQuery : IRequest<GetOrderQueryResponse>
    {
        public int Id { get; set; }
    }
}
