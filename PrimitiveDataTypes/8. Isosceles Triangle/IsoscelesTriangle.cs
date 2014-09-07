using System;

namespace _8.Isosceles_Triangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            char cr = '\u00a9';
            Console.WriteLine("   " + cr);
            Console.WriteLine("  " + cr + " " + cr);
            Console.WriteLine(" " + cr + "   " + cr);
            Console.WriteLine( new string(cr, 7));
        }
    }
}
