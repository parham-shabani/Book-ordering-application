using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderItemCommands.UpdateOrderItem
{
    public class UpdateOrderItemDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int BookId { get; set; }
    }
}
