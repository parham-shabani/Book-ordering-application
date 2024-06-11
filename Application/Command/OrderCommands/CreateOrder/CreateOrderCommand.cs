using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderCommands.CreateOrder
{
    public record CreateOrderCommand(int Id, DateTime OrderDate, int Customer, int OrderItems) : IRequest<Unit>;
    
}
