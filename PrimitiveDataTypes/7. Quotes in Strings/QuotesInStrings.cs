using System;

namespace _7.Quotes_in_Strings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string first = @"The ""use"" of quotations causes difficulties.";
            string second = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
