using System;

namespace Delegates
{
    // Object that knows how to call a method (or a group of methods)
    // A reference, or pointer, to a function
    //
    // Designing extensible and flexible applications
    //
    // Use a delegate when: ---------------------------------------
    // 1. An eventing design pattern is used
    // 2. Use delegates when the caller doesn't need access to other 
    // properties or methods on the object implementing the method

    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += RemoveRedEyeFilter;
            filterHandler += filters.ApplyContrast;
            // Using filterHandler (delegate)
            processor.Processing("photo.jpg", filterHandler);

            // Using Action<Photo>            
            processor.Process("image.jpg", filters.ApplyBrightness);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye");
        }
    }
}
