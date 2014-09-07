using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.The_Biggest_of_3_Numbers
{
    class TheBiggestOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a three numbers: ");

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if ((a>b)&&(a>c))
            {
                Console.WriteLine(a);
            }
            else if((b>a)&&(b>c))
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
