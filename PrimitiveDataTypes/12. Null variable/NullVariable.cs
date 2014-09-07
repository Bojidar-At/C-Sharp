using System;

namespace _12.Null_variable
{
    class NullVariable
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int? c = a + 5;
            Console.WriteLine(c);
        }
    }
}
