using Application.Command.Book.UpdateBook;
using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.CustomerCommands.UpdateCustomer
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, int>
    {
        private readonly ICustomerWriteService _customerWriteService;
        public UpdateCustomerHandler(ICustomerWriteService customerWriteService)
        {
            _customerWriteService = customerWriteService;
        }

        public async Task<int> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerWriteService.UpdateAsync(request);
            return request.id;
        }

    }
}
