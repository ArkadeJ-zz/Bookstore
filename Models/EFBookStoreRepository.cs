using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//EF Repos file
namespace Bookstore.Models
{
    public class EFBookStoreRepository : iBookStoreRepository
    {
        private BookStoreContext _context;

        //constructor
        public EFBookStoreRepository (BookStoreContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
