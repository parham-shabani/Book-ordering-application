using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderCommands.UpdateOrder
{
    public class UpdateOrderDto
    {
        public int Id { get; set; }
        public DateTime orderDate { get; set; }
        public int customer { get; set; }
        public int OrderId { get; set; }
    }
}
