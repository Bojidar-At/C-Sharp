using System;

namespace _13.Modify_a_Bit
{
    class ModifyABit
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a position");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a value (\"0\" or \"1\")");
            int v = int.Parse(Console.ReadLine());

            if (v == 0)
            {
                int maskV = ~(1 << p);
                int maskFirst = maskV & n;
                Console.WriteLine("Binary result is: {0}", maskFirst);
            }
            else if (v == 1)
            {
                int maskVV = v << p;
                int maskFirst = maskVV | n;
                Console.WriteLine("Binary result is: {0}", maskFirst);
            }
            else
            {
                Console.WriteLine("Invalid value !");
            }
        }
    }
}
