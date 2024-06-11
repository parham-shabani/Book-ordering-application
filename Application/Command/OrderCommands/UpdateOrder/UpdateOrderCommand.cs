using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderCommands.UpdateOrder
{
    public record UpdateOrderCommand(int id, UpdateOrderDto order) : IRequest<int>;
    
}
