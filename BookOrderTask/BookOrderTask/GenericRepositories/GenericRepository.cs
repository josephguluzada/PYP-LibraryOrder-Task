namespace BookOrderTask.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private List<T> TList;

        public GenericRepository(List<T> tList)
        {
            TList = tList;
        }

        public void Add(T item)
        {
            TList.Add(item);
        }

        public void Delete(T item)
        {
            TList?.Remove(item);
        }

        public T Get(Func<T, bool> predicate)
        {
          return TList.FirstOrDefault(predicate);
           
        }

        public List<T> GetAll(Func<T, bool> predicate = null)
        {
            return predicate == null ? TList : TList.Where(predicate).ToList();
        }

        public int RemoveAll(Func<T, bool> predicate)
        {
          return predicate!=null ? TList.RemoveAll(x => predicate(x)) : 0;

        }
    }
}
