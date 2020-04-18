using System;

namespace Dynamics
{
    class Program
    {
        // Static-typed languages: C#, Java --- At compile-time (early feedback)
        // Dynamically-typed languages: Ruby, Javascript, Python --- at run-time (easier faster code)
        //
        // .NET 4 added dynamic capability
        // REFLECTION
        static void Main(string[] args)
        {
            var i = 5;
            dynamic d = i;
            long l = d;
            //dynamic a = 10;
            //dynamic b = 5;
            //var c = a + b;
        }

        public void TestStuff()
        {
            object obj = "Mosh";
            // No reflection
            //obj.GetHashCode();

            // Reflection
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            // Error - Optimize doesn't exist yet
            var exObject = "moshi";
            //exObject.Optimize();
            // Dynamic 
            dynamic excelObject = "mosh";
            excelObject.Optimize();
        }
    }
}
