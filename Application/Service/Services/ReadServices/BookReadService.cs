using Application.Query.BookQueries.GetBook;
using Application.Service.IServices.IReadServices;
using Domain.Repositories;
using Domain.Repositories.BookRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.ReadServices
{
    public class BookReadService : IBookReadService
    {

        private readonly IBookReadRepository _bookReadRepository;
        private readonly IDapperUnitOfWork _unitOfWork;
        public BookReadService(IBookReadRepository bookReadRepository, IDapperUnitOfWork unitOfWork) { 
            _bookReadRepository = bookReadRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<GetBookQueryResponse> GetBookByIdAsync(int id) {
            var book = await _bookReadRepository.GetByIdAsync(id);

            var result = new GetBookQueryResponse
            {
                Id = book.BookId, 
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
                ImageUrl = book.ImageUrl,
            };
            return result;
        }

        public async Task<IEnumerable<GetBookQueryResponse>> GetBooksAsync()
        {
            var books = await _bookReadRepository.GetAllAsync();

            var result = books.Select(book => new GetBookQueryResponse
            {
                Id = book.BookId,
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
                ImageUrl = book.ImageUrl,
            }).ToList();

            return result;
        }


    }
}
