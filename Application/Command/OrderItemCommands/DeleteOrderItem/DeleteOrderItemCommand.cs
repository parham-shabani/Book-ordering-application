using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderItemCommands.DeleteOrderItem
{
    public record DeleteOrderItemCommand(int id) : IRequest;
 
}
