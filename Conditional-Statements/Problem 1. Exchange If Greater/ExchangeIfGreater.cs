using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Exchange_If_Greater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write two numbers: ");

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
