using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Query.BookQueries.GetBook;

namespace Application.Service.IServices.IReadServices
{
    public interface IBookReadService
    {
        Task<IEnumerable<GetBookQueryResponse>> GetBooksAsync();
        Task<GetBookQueryResponse> GetBookByIdAsync(int id);
    }
}
