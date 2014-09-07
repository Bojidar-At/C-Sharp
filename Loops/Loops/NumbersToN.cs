using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number N:");
            int n = int.Parse(Console.ReadLine());

            int a = 1;

            while (a<=n)
            {
                Console.Write(a+ " ");
                a++;
            }

        }
    }
}
