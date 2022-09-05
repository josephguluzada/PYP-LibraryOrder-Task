using BookOrderTask.Models;
using BookOrderTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrderTask.LibraryRepository
{
    public interface ILibraryRepository : IGenericRepository<Library>
    {
    }
}
