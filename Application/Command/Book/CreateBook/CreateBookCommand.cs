using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Book.CreateBook
{
    public record CreateBookCommand(int bookId, string Title, string Description, int Price, string ImageUrl) : IRequest<Unit>;
}
