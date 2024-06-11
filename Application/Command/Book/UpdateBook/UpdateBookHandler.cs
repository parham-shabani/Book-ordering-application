using Application.Service.IServices.IWriteServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Book.UpdateBook
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, int>
    {
        private readonly IBookWriteService _bookWriteService;
        public UpdateBookHandler(IBookWriteService bookWriteService)
        {
            _bookWriteService = bookWriteService;
        }

        public async Task<int> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            await _bookWriteService.UpdateAsync(request);
            return request.bookId;
        }

    }
}
