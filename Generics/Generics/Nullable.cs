using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Generics
{
    // T has to be a value type ----- (struct)
    public class Nullable<T> where T : struct
    {
        private object _value;

        // Default constructor in case the value is not set.
        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T) _value;

            return default(T);
        }
    }
}
