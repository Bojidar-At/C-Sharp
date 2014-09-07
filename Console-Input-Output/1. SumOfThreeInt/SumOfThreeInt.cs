using System;
namespace _1.SumOfThreeInt
{
    class SumOfThreeInt
    {
        static void Main()
        {
            Console.Write("Please write number \"a\": ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Please write number \"b\": ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Please write number \"c\": ");
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("The sum of \"a\" + \"b\" + \"c\" is: {0}", (a+b+c));

        }
    }
}
