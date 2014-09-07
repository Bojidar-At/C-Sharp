using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sort_3_Numbers_with_Nested_Ifs
{
    class SortThreeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three number:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.Write(a + " ");
                    if (b > c) Console.WriteLine(b + " " + c);
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.Write(b + " ");
                    if (a > c) Console.WriteLine(a + " " + c);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }
}
