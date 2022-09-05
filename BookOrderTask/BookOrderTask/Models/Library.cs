namespace BookOrderTask.Models
{
    public class Library
    {
        private static int _count;
        public Library()
        {
            _count++;
            Id = _count;
        }
        public int Id { get; set; }
        public List<Book> Books { get; set; }=new List<Book>();
    }

    
}
