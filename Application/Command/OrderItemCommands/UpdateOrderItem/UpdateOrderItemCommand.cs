using Application.Command.CustomerCommands.UpdateCustomer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderItemCommands.UpdateOrderItem
{
    public record UpdateOrderItemCommand(int id, UpdateOrderItemDto orderItem) : IRequest<int>;
    
}
