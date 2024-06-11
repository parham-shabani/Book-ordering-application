using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories.BookRepositories
{
    public interface IBookWriteRepository
    {
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteByIdAsync(int id);
    }
}
