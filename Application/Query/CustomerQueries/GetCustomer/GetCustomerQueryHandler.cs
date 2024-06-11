using Application.Query.BookQueries.GetBook;
using Application.Service.IServices.IReadServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.CustomerQueries.GetCustomer
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, GetCustomerQueryResponse>
    {
        private readonly ICustomerReadService _customerReadService;
        public GetCustomerQueryHandler(ICustomerReadService customerReadService)
        {
            _customerReadService = customerReadService;
        }

        public async Task<GetCustomerQueryResponse> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var result = await _customerReadService.GetCustomerByIdAsync(request.Id);
            return result;
        }
    }
}
