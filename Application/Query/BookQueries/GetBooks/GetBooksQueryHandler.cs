using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Query.BookQueries.GetBook;
using Application.Service.IServices.IReadServices;

namespace Application.Query.BookQueries.GetBooks
{
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, IEnumerable<GetBookQueryResponse>>
    {
        private readonly IBookReadService _bookReadService;
        public GetBooksQueryHandler(IBookReadService bookReadService)
        {
            _bookReadService = bookReadService;
        }

        public async Task<IEnumerable<GetBookQueryResponse>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var result = await _bookReadService.GetBooksAsync();
            return result;
        }
    }
}
