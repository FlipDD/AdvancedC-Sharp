using System;
using System.IO;
using System.Net.Http.Headers;

namespace ExceptionHandling
{
    partial class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void Test()
        {
            try
            {
                // Using is the same as try/finally, with .Dispose in finally
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
        }

        void OldTests()
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0); // throws DivideByZeroException
            }
            // catch should be ordered by hierarchy
            // if we put "Exception" first it'll catch it and not do anything else, so we try specifics first
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {

            }
        }
    }
}
