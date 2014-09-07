using System;

namespace _14.Bits_Exchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            uint n = uint.Parse(Console.ReadLine());
            
            uint firstBits = 7 << 3;
            uint copyFirstBits = n & firstBits;
            uint secondBits = 7 << 24;
            uint copySecondBits = n & secondBits;
            Console.WriteLine("copyFirstBits is: {0}", copyFirstBits);
            Console.WriteLine("copySecondBits is: {0}", copySecondBits);

            long delFirstBits = ~(7 << 3);
            long deletedFirst = (delFirstBits & n);
            long delSecondBits = ~(7 << 24);
            long deletedSecond = (delSecondBits & n);
            long cleanedNumber = deletedFirst & deletedSecond;
            Console.WriteLine("deletedFirst is: {0}", deletedFirst);
            Console.WriteLine("deletedSecond is: {0}", deletedSecond);
            Console.WriteLine("cleanedNumber is {0}", cleanedNumber);

            uint moveCopyFirstBits = copyFirstBits << 21;
            uint moveCopySecondBits = copySecondBits >> 21;
            Console.WriteLine("moveCopyFirst is: {0}", moveCopyFirstBits);
            Console.WriteLine("moveCopySecondBits is: {0}", moveCopySecondBits);

            long pasteFirstBits = cleanedNumber | moveCopyFirstBits;
            long pasteSecondBits = pasteFirstBits | moveCopySecondBits;
            Console.WriteLine("pasteFirstBits is: {0}", pasteFirstBits);


            Console.WriteLine("The result is: {0}", pasteSecondBits);


        }
    }
}
