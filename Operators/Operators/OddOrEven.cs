using System;

namespace Operators
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int a = 3;         
            if (a % 2 == 0)
            {
                Console.WriteLine("Числото е четно");
            }
            else 
            {
                Console.WriteLine("Числото е нечетно");
            }

            int b = 2;
            bool checkB = (b % 2 != 0);
            Console.WriteLine(checkB);
          
            int c = -2;
            bool checkC = (c % 2 != 0);
            Console.WriteLine(checkC);
            
            int d = -1;
            bool checkD = (d % 2 != 0);
            Console.WriteLine(checkD);

            int e = 0;
            bool checkE = (e % 2 != 0);
            Console.WriteLine(checkE);
        }
    }
}
