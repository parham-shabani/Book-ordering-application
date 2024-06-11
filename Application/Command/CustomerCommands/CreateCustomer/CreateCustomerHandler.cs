using Application.Command.Book.CreateBook;
using Application.Service.IServices.IWriteServices;
using Application.Service.Services.WriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.CustomerCommands.CreateCustomer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand ,Unit>
    {
        private readonly ICustomerWriteService _customerWriteService;
        public CreateCustomerHandler(ICustomerWriteService customerWriteService) {
            _customerWriteService = customerWriteService;
        }

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _customerWriteService.AddAsync(request);
            return Unit.Value;
        }
    }
}
