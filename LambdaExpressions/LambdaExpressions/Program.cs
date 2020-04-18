using System;
using System.Threading;

namespace LambdaExpressions
{
    // An anonymous method
    //      No access modifier
    //      No name
    //      No return statement
    //
    // Why?
    //      For convenience
    partial class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // () => ...
            // x => ...
            // x, y, z => ...
            Func<int, int> square = Square;
            Func<int, int> squareInLine = number => number * number;

            const int factor = 5;
            Func<int, int> multiplier = number => number * factor;
            var result = multiplier(5);

            Console.WriteLine("Square " + square(5));
            Console.WriteLine("Square in line " + squareInLine(5));
            Console.WriteLine("Multiplier " + result);


            // Using in predicates (FindAll)
            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static int Square(int number) => number * number;

        static bool IsCheaperThan10Dollars(Book book) => book.Price < 10;
    }
}
