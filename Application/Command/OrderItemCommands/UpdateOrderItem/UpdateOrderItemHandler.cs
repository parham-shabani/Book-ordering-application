using Application.Command.CustomerCommands.UpdateCustomer;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderItemCommands.UpdateOrderItem
{
    public class UpdateOrderItemHandler : IRequestHandler<UpdateOrderItemCommand, int>
    {
        private readonly IOrderItemWriteService _orderItemWriteService;
        public UpdateOrderItemHandler(IOrderItemWriteService orderItemWriteService)
        {
            _orderItemWriteService = orderItemWriteService;
        }

        public async Task<int> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
        {
            await _orderItemWriteService.UpdateAsync(request);
            return request.id;
        }
    }
}
