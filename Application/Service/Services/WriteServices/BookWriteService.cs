using Application.Command.Book.CreateBook;
using Application.Command.Book.UpdateBook;
using Application.Service.IServices.IWriteServices;
using Domain.Entity;
using Domain.Repositories.BookRepositories;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Services.WriteServices
{
    public class BookWriteService : IBookWriteService
    {
        private readonly IEFUnitOfWork _unitOfWork;
        //private readonly IBookWriteRepository _bookWriteRepository;
        public BookWriteService(IEFUnitOfWork unitOfWork, IBookWriteRepository bookWriteRepository)
        {
            _unitOfWork = unitOfWork;
          
        }

        public async Task AddAsync(CreateBookCommand request)
        {
            var book = new Book
            {
                BookId = request.bookId,
                Title = request.Title,
                Description = request.Description,
                Price = request.Price,
                ImageUrl = request.ImageUrl
            };
            await _unitOfWork.BookWriteRepository.AddAsync(book);
            await _unitOfWork.Complete();

            
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _unitOfWork.BookWriteRepository.DeleteByIdAsync(id);
            await _unitOfWork.Complete();
        }

        public async Task UpdateAsync(UpdateBookCommand request)
        {
            var book = new Book
            {
                BookId = request.book.bookId,
                Title = request.book.Title,
                Description = request.book.Description,
                Price = request.book.Price,
                ImageUrl = request.book.ImageUrl
            };
            await _unitOfWork.BookWriteRepository.UpdateAsync(book);
            await _unitOfWork.Complete();
        }
    }
}
