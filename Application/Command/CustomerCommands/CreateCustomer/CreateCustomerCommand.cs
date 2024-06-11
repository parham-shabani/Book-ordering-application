using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.CustomerCommands.CreateCustomer
{
    public record CreateCustomerCommand(int Id, string Name, string Phone) : IRequest<Unit>;
}
