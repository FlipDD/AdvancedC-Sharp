using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());


            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new Dictionary<string, Book>();
            //dictionary.Add("12345", new Book());
        }
    }
}
