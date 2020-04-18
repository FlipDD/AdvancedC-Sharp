using System;
using System.ComponentModel;
using System.Data;

namespace NullableTypes
{
    class Program
    {
        ////////////////////////////////////////////
        // Value types
        // Cannot be null
        // * bool hasAccess = true; // or false
        // * int n = is always a number
        //
        // Database
        // Not everyone want to put in their birthday
        // Customers.Birthday (date time NULL)
        ////////////////////////////////////////////

        static void Main(string[] args)
        {
            // Cannot be null
            // DateTime data = null;
            // so,
            Nullable<DateTime> dateBd = null;
            DateTime? date = null; // shorter version

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            // This throws InvalidOperationException
            //Console.WriteLine("Value: " + date.Value);

            /////////////////////////////////////////////////////////////////////
            DateTime? date1 = new DateTime(2014, 1, 1);
            // Doesn't work because isn't nullable
            //DateTime date2 = date1;
            // Works 
            DateTime date2 = date1.GetValueOrDefault();
            // Works
            DateTime? date3 = date2;

            Console.WriteLine(date2);

            //////////////////////////////////////////
            // Null Coalescing Operator 
            DateTime? nDate1 = null;
            DateTime nDate2;

            if (nDate1 != null)
                nDate2 = nDate1.GetValueOrDefault();
            else
                nDate2 = DateTime.Today;

            Console.WriteLine(nDate2);
            // Null Coalescing Operator (Actual usage)
            DateTime? nDate3 = null;
            DateTime nDate4 = nDate3 ?? DateTime.Today;

            Console.WriteLine(nDate4);

            //////////////////////////////////////////////////////////////////////////////
            /// Tertiary Operator
            DateTime date5 = (nDate3 != null) ? nDate3.GetValueOrDefault() : DateTime.Today;
        }
    }
}
