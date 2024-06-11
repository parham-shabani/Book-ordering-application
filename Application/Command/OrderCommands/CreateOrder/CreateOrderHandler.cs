using Application.Command.CustomerCommands.CreateCustomer;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderCommands.CreateOrder
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Unit>
    {
        private readonly IOrderWriteService _orderWriteService;
        public CreateOrderHandler(IOrderWriteService orderWriteService)
        {
            _orderWriteService = orderWriteService;
        }

        public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            await _orderWriteService.AddAsync(request);
            return Unit.Value;
        }
    }
}
