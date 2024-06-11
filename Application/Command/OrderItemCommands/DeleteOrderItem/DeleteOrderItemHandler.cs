using Application.Command.CustomerCommands.DeleteCustomer;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderItemCommands.DeleteOrderItem
{
    public class DeleteOrderItemHandler : IRequestHandler<DeleteOrderItemCommand>
    {
        private readonly IOrderItemWriteService _orderItemWriteService;
        public DeleteOrderItemHandler(IOrderItemWriteService orderItemWriteService)
        {
            _orderItemWriteService = orderItemWriteService;
        }

        public async Task Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
        {
            await _orderItemWriteService.DeleteByIdAsync(request.id);

        }
    }
}
