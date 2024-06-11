using Application.Query.OrderItemQueries.GetOrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.IServices.IReadServices
{
    public interface IOrderItemReadService
    {
        Task<GetOrderItemQueryResponse> GetOrderItemByIdAsync(int id);
        Task<IEnumerable<GetOrderItemQueryResponse>> GetOrderItemsAsync();
    }
}
