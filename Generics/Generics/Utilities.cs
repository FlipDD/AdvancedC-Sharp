using System;

namespace Generics
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            // Doesn't work because the compiler doesn't know the type it's referring to
            // So we apply second constraint, new()
            var obj = new T();
        }

        // We can remove T and where T : IComparable because we moved it to the class
        public T Max(T a, T b)        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
