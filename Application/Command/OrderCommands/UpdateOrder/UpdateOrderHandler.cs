using Application.Command.CustomerCommands.UpdateCustomer;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderCommands.UpdateOrder
{
    public class UpdateOrderHandler : IRequestHandler<UpdateOrderCommand, int>
    {
        private readonly IOrderWriteService _orderWriteService;
        public UpdateOrderHandler(IOrderWriteService orderWriteService)
        {
            _orderWriteService = orderWriteService;
        }

        public async Task<int> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            await _orderWriteService.UpdateAsync(request);
            return request.id;
        }
    }
}
