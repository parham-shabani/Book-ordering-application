using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderItemQueries.GetOrderItem
{
    public class GetOrderItemQueryResponse
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
