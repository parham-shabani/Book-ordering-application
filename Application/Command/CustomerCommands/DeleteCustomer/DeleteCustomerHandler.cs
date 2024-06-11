using Application.Command.Book.DeleteBook;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.CustomerCommands.DeleteCustomer
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerWriteService _customerWriteService;
        public DeleteCustomerHandler(ICustomerWriteService customerService)
        {
            _customerWriteService = customerService;
        }

        public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerWriteService.DeleteByIdAsync(request.Id);

        }
    }
}
