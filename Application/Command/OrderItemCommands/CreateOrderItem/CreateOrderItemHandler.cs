using Application.Command.CustomerCommands.CreateCustomer;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderItemCommands.CreateOrderItem
{
    public class CreateOrderItemHandler : IRequestHandler<CreateOrderItemCommand, Unit>
    {
        private readonly IOrderItemWriteService _orderItemWriteService;
        public CreateOrderItemHandler(IOrderItemWriteService orderItemWriteService)
        {
            _orderItemWriteService = orderItemWriteService;
        }

        public async Task<Unit> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            await _orderItemWriteService.AddAsync(request);
            return Unit.Value;
        }
    }
}
