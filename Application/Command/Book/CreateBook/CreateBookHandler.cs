using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Book.CreateBook
{
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, Unit>
    {
        private readonly IBookWriteService _bookWriteService;
        public CreateBookHandler(IBookWriteService bookService)
        {
            _bookWriteService = bookService;
        }

        public async Task<Unit> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _bookWriteService.AddAsync(request);
            return Unit.Value;
        }
    }
}
