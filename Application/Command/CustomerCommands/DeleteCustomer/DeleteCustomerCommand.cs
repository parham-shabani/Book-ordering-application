using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.CustomerCommands.DeleteCustomer
{
    public record DeleteCustomerCommand(int Id) : IRequest;
    
}
