using Application.Query.CustomerQueries.GetCustomer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.CustomerQueries.GetCustomers
{
    public record GetCustomersQuery : IRequest<IEnumerable<GetCustomerQueryResponse>>
    {

    }
}
