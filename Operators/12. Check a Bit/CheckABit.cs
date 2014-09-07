using System;

namespace _12.Check_a_Bit
{
    class CheckABit
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a position");
            int p = int.Parse(Console.ReadLine());

            int mask = n >> p;
            bool checkBit = (mask & 1) == 1;
            Console.WriteLine("The position \"p\" has a 1: {0}", checkBit);
         }
    }
}
