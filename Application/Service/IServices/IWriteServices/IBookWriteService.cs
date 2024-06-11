using Application.Command.Book.CreateBook;
using Application.Command.Book.UpdateBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.IServices.IWriteServices
{
    public interface IBookWriteService
    {
        Task AddAsync(CreateBookCommand request);
        Task UpdateAsync(UpdateBookCommand request);
        Task DeleteByIdAsync(int id);
    }
}
