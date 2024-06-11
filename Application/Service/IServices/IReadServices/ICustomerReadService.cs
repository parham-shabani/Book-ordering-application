using Application.Query.CustomerQueries.GetCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.IServices.IReadServices
{
    public interface ICustomerReadService
    {
        Task<IEnumerable<GetCustomerQueryResponse>> GetCustomersAsync();
        Task<GetCustomerQueryResponse> GetCustomerByIdAsync(int id);
    }
}
