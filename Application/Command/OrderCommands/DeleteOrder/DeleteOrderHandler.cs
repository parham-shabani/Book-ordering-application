using Application.Command.CustomerCommands.DeleteCustomer;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.OrderCommands.DeleteOrder
{
    public class DeleteOrderHandler : IRequestHandler<DeleteOrderCommand>
    {
        private readonly IOrderWriteService _orderWriteService;
        public DeleteOrderHandler(IOrderWriteService orderWriteService)
        {
            _orderWriteService = orderWriteService;
        }

        public async Task Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            await _orderWriteService.DeleteByIdAsync(request.Id);

        }
    }
}
