using BookOrderTask.Models;
using BookOrderTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrderTask.BookRepository
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(List<Book> tList) : base(tList)
        {

        }
    }
}
