
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.CustomerQueries.GetCustomer
{
    public record GetCustomerQuery : IRequest<GetCustomerQueryResponse>
    {
        public int Id { get; set; }
    }
}
