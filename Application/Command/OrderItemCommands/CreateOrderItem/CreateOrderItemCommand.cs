using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderItemCommands.CreateOrderItem
{
    public record CreateOrderItemCommand(int Id, int BookId, int Quantity, int TotalPrice) : IRequest<Unit>;
    
}
