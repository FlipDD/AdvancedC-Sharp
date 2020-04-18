using System.Collections;
using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Title 1", Price = 5 },
                new Book() { Title = "Title 2", Price = 9.99f },
                new Book() { Title = "Title 3", Price = 12 },
                new Book() { Title = "Title 4", Price = 7 },
                new Book() { Title = "Title 5", Price = 9 }
            };
        }
    }
}
