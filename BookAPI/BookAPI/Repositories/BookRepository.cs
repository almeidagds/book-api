using BookAPI.Model;
using System.Security.Cryptography.X509Certificates;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly BookContext _context;
        public BookRepository(BookContext context) 
        {
            _context = context;
        }

        public Task<Book> Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Delet(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
