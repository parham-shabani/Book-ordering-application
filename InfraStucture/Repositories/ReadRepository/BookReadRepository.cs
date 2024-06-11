using Dapper;
using Domain.Entity;
using Domain.Repositories.BookRepositories;
using InfraStucture.Persistance.Dapper;


namespace InfraStucture.Repositories.ReadRepository
{
    public class BookReadRepository : IBookReadRepository
    {
        private readonly DapperContext dataBaseContext;

        public BookReadRepository(DapperContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            
            try
            {
                const string query = "SELECT * FROM Books";
                return await dataBaseContext.connection.QueryAsync<Book>(query, transaction: dataBaseContext.transaction);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dataBaseContext.Dispose();
            }
            return new List<Book>();
        }

        public async Task<Book> GetByIdAsync(int bookId)
        {
            try
            {
                const string query = "SELECT * FROM Books WHERE BookId = @BookId";
                return await dataBaseContext.connection.QuerySingleOrDefaultAsync<Book>(query, new { BookId = bookId }, transaction: dataBaseContext.transaction);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dataBaseContext.Dispose();

            }
            return new Book();
        }
    }
}
