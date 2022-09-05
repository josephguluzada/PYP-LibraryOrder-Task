namespace BookOrderTask.Models
{
    public class Order
    {
        private static int _count;
        public Order()
        {
            _count++;
            Id = _count;
            Books = new List<Book>();
        }
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        
        
        public double Purchase(Func<double> func = null)
        {
            TotalPrice = Books.Sum(x => x.Price);
            OrderDate = DateTime.Now;
            func ??= MakeDiscount0;
            Console.WriteLine($"Endirimsiz qiymet ==> {TotalPrice}");
            return Math.Round(TotalPrice *= func(),2); 
        }

        public static double MakeDiscount20()
        {
            return 0.8d;
        }

        public static double MakeDiscount10()
        {
            return 0.9d;
        }
        public static double MakeDiscount0()
        {
            return 1d;
        }
    }
}
