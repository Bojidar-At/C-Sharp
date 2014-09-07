using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Fibonacci
{
    class Fibonacci
    {
        public static int Fib(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= n-1; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
            
        }

        static void Main()
        {
            Console.WriteLine("Дайте номер от редицата на Фибонаюи! Тук: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("n = {0}", Fib(n));
        }
    }
}
