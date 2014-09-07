using System;

namespace _4.Greather_number
{
    class GreaterNumber
    {
        static void Main()
        {
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());
           Console.WriteLine("The Greater number is: {0}", Math.Max(a,b));
        }
    }
}
