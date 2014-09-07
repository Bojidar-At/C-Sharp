using System;

namespace _9.Exchange_Variable
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            int c = a + b;
            Console.WriteLine("The exchange value of integare are: a = {0}, b = {1}", c-a, c-b);
        }
    }
}
