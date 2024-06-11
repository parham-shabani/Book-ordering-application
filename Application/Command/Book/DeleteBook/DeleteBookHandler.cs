using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Book.DeleteBook
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IBookWriteService _bookWriteService;
        public DeleteBookHandler(IBookWriteService bookService)
        {
            _bookWriteService = bookService;
        }

        public async Task Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            await _bookWriteService.DeleteByIdAsync(request.Id);
            
        }
    }
}
