using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of Fibonacci sequence: ");
            BigInteger length = BigInteger.Parse(Console.ReadLine());

            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger c = 1;

            Console.Write("0 ");
            Console.Write("1 ");

            for (BigInteger i = 0; i < length; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }
    }
}
