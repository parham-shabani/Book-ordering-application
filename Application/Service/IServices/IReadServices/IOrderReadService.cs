using Application.Query.BookQueries.GetBook;
using Application.Query.OrderQueries.GetOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.IServices.IReadServices
{
    public interface IOrderReadService
    {
        Task<IEnumerable<GetOrderQueryResponse>> GetOrdersAsync();
        Task<GetOrderQueryResponse> GetOrderByIdAsync(int id);
    }
}
