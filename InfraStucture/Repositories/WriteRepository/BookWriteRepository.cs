using Domain.Entity;
using Domain.Repositories.BookRepositories;
using InfraStucture.Persistance.Dapper;
using InfraStucture.Persistance.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStucture.Repositories.WriteRepository
{
    public class BookWriteRepository : IBookWriteRepository
    {
        private readonly EFContext _efContext;

        public BookWriteRepository(EFContext efContext)
        {
            _efContext = efContext;
        }


        public async Task AddAsync(Book book)
        {
            await _efContext.Books.AddAsync(book);
        }
        public async Task UpdateAsync(Book book)
        {
            _efContext.Books.Update(book);
        }
        public async Task DeleteByIdAsync(int id)
        {
            var book = await _efContext.Books.Where(b => b.BookId == id).FirstAsync();
            _efContext.Books.Remove(book);
        }
    }
}
