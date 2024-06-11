using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Book.DeleteBook
{
    public record DeleteBookCommand(int Id) : IRequest;
}
