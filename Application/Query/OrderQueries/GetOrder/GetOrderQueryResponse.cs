using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.OrderQueries.GetOrder
{
    public class GetOrderQueryResponse
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int Customer { get; set; }
        public int OrderItems { get; set; }
    }
}
