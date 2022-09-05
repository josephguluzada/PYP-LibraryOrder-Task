
using BookOrderTask.BookRepository;
using BookOrderTask.Models;
Library library = new();

BookRepository repository = new BookRepository(library.Books);
repository.Add(new Book("Animal farms","George Orwel",112,23d));
repository.Add(new Book("Karmazov brother","F.M.D",748,42d));
repository.Add(new Book("Kafka Sahilde","Murakami",212,51d));

repository.GetAll().ForEach(p=>Console.WriteLine(p.ToString()));
repository.RemoveAll(null);
repository.GetAll().ForEach(p=>Console.WriteLine(p.ToString()));

Order order = new Order();

order.Books.AddRange(new List<Book>()
{
    new Book("Animal farms","George Orwel",112,23.2d),
    new Book("Karmazov brother","F.M.D",748,42.3d)
});

Console.WriteLine(order.Purchase(()=>
{
    return 0.5d;
}));




