using Application.Service.IServices.IReadServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.BookQueries.GetBook
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, GetBookQueryResponse>
    {
        private readonly IBookReadService _bookReadService;
        public GetBookQueryHandler(IBookReadService bookReadService)
        {
            _bookReadService = bookReadService;
        }

        public async Task<GetBookQueryResponse> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var result = await _bookReadService.GetBookByIdAsync(request.Id);
            return result;
        }
    }
}
