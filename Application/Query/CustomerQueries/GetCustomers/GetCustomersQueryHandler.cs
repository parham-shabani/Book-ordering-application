using Application.Query.BookQueries.GetBooks;
using Application.Query.CustomerQueries.GetCustomer;
using Application.Service.IServices.IReadServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.CustomerQueries.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, IEnumerable<GetCustomerQueryResponse>>
    {
        private readonly ICustomerReadService _customerReadService;
        public GetCustomersQueryHandler(ICustomerReadService customerReadService)
        {
            _customerReadService = customerReadService;
        }


        public async Task<IEnumerable<GetCustomerQueryResponse>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var result = await _customerReadService.GetCustomersAsync();
            return result;
        }
    }
}
