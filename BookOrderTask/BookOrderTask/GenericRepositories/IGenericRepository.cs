using BookOrderTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrderTask.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(Func<T,bool> predicate);
        List<T> GetAll(Func<T, bool> predicate=null);
        void Add(T item);
        int RemoveAll(Func<T,bool> predicate);
        void Delete(T item);
    }
}
