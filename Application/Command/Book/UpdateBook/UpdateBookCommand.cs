using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Book.UpdateBook
{
    public record UpdateBookCommand(int bookId, UpdateBookDto book) : IRequest<int>;
}
