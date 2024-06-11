using Application.Query.BookQueries.GetBook;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.BookQueries.GetBooks
{
    public record GetBooksQuery : IRequest<IEnumerable<GetBookQueryResponse>>
    {

    }
}
