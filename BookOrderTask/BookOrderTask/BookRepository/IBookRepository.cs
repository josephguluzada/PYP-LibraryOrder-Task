using BookOrderTask.Models;
using BookOrderTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrderTask.BookRepository
{
    public interface IBookRepository : IGenericRepository<Book>
    {
    }
}
