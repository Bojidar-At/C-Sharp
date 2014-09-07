using System;

namespace _15.Bit_Exchange__Advanced_
{
    class BitExchangeAdvanced
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            long n = uint.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a \"p\"");
            var p = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a \"q\"");
            var q = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a \"k\"");
            var k = sbyte.Parse(Console.ReadLine());

            if (Math.Max(p, q) + k > 32)
            {
                Console.WriteLine("Out of range");
            }
            else if (Math.Min(p, q) + k > Math.Max(p, q))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                long kCels = (long)(Math.Pow(2, k)-1);
                long firstBits = kCels << (Math.Min(p, q));
                long copyFirstBits = n & firstBits;
                long secondBits = kCels << (Math.Max(p, q));
                long copySecondBits = n & secondBits;
                Console.WriteLine(kCels);

                long delFirstBits = ~(kCels << (Math.Min(p, q)));
                long deletedFirst = (delFirstBits & n);
                long delSecondBits = ~(kCels << (Math.Max(p, q)));
                long deletedSecond = (delSecondBits & n);
                long cleanedNumber = deletedFirst & deletedSecond;

                long moveCopyFirstBits = copyFirstBits << ((Math.Max(p, q)) - (Math.Min(p, q)));
                long moveCopySecondBits = copySecondBits >> ((Math.Max(p, q)) - (Math.Min(p, q)));

                long pasteFirstBits = cleanedNumber | moveCopyFirstBits;
                long pasteSecondBits = pasteFirstBits | moveCopySecondBits;


                Console.WriteLine("The result is: {0}", pasteSecondBits);
            }
        }
    }
}
