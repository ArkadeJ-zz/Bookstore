using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Repository File
namespace Bookstore.Models
{
    public interface iBookStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
