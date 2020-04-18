using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    // Allow us to add methods to an existing class without
    //      changing its source code
    //      create a new class that inherits from it

    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long long blog post sdkadpalkpdakls......";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 2, 7, 4, 18, 8};
            var max = numbers.Max();

            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);
        }
    }
}
