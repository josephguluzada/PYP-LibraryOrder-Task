using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOrderTask.Models
{
    public class Book
    {
        private static int _count;
        private Book()
        {
            _count++;
            Id = _count;
        }

        public Book(string name, string authorName, int pageCount, double price) : this()
        {

            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Price = price;
            Code = CreateCode();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }
        public override string ToString()
        {
            return Code;
        }

        private string CreateCode()
        {
            var str = Name.Trim().Split();
            StringBuilder resultStr=new StringBuilder();
            foreach (var item in str)
            {
                resultStr.Append(item.Substring(0,1).ToUpper());
            }
            resultStr.Append($"-{_count}");
            return resultStr.ToString();
        }
    }
}
