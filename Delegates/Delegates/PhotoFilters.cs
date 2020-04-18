using System;

namespace Delegates
{
    internal class PhotoFilters
    {
        internal void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }

        internal void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        internal void Resize(Photo photo)
        {
            Console.WriteLine("Apply Resize");
        }
    }
}