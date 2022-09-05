using BookOrderTask.Models;
using BookOrderTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrderTask.LibraryRepository
{


    public class LibraryRepository : GenericRepository<Library>, ILibraryRepository
    {
        public LibraryRepository(List<Library> tList) : base(tList)
        {
        }
    }
}
