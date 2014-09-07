using System;

namespace _11.Bitwise
{
    class Bitwise
    {
        static void Main()
        {
            Console.WriteLine("Please input a number");
            int a = int.Parse(Console.ReadLine());
            int ckeckA = a >> 3;
            int newBit = ckeckA & 1;
            Console.WriteLine("The third bit of a number is {0}", newBit);
        }
    }
}
