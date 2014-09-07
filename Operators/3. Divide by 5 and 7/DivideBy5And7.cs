using System;

namespace _3.Divide_by_5_and_7
{
    class DivideBy5And7
    {
        static void Main()
        {
            int a = 35;
            bool checkedA = ((a%7==0)&&(a%5==0)); 
            Console.WriteLine("Are the integer has divided by 5 and 7 at same time: {0}", checkedA);

            int b = 3;
            bool checkedB = ((b % 7 == 0) && (b % 5 == 0));
            Console.WriteLine("Are the integer has divided by 5 and 7 at same time: {0}", checkedB);

            int c = 0;
            bool checkedC = ((c % 7 == 0) && (c % 5 == 0) && (c != 0));
            Console.WriteLine("Are the integer has divided by 5 and 7 at same time: {0}", checkedC);

            int d = 5;
            bool checkedD = ((d % 7 == 0) && (d % 5 == 0));
            Console.WriteLine("Are the integer has divided by 5 and 7 at same time: {0}", checkedD);

            int e = 140;
            bool checkedE = ((e % 7 == 0) && (e % 5 == 0));
            Console.WriteLine("Are the integer has divided by 5 and 7 at same time: {0}", checkedE);
        }
    }
}
