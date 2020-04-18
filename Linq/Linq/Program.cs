using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Cool extension methods?
            //
            // (Single) Will crash if there any no matching titles (InvalidOperationException)
            //var newBook = books.Single(b => b.Title == "Title 1f");
            // (SingleOrDefault) Will crash only if you don't check for null (NullReferenceException)
            //var newBook = books.SingleOrDefault(b => b.Title == "Title 1tt");
            // (First)
            // var newBook = books.First(b => b.Title.Contains("Title"));
            // (FirstOrDefault) same thing - doesn't throw invalid expection, will throw null if error instead
            //
            //var pagedBooks = books
            //    .Skip(2)
            //    .Take(3);
            //
            var maxPrice = books.Max(b => b.Price); // 12
            var minPrice = books.Min(b => b.Price); // 5
            var totalPrices = books.Sum(b => b.Price); //42.99


            ////////////////////////////////////////////////////
            // With Linq ///////////////////////
            // var cheapBooks = books.Where(b => b.Price < 10);
            // Extra
            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title);
            // LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            // Without Linq ////////////////////
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}
            Console.WriteLine("\n Cheap books: ");
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            Console.WriteLine("\n Cheaper books:");
            foreach (var book in cheaperBooks)
                Console.WriteLine(cheaperBooks);

            // LINQ Extension Methods
            var cheapBooksString = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            Console.WriteLine("\n CheapBooksString:");
            foreach (var book in cheapBooksString)
                Console.WriteLine(book);
            /////////////////////////////////////////////////////
        }
    }
}
