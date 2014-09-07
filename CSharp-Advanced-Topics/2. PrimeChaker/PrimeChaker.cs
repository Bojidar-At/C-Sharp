using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrimeChaker
{
    class PrimeChaker
    {
        static void Main()
        {
            int num1;

            Console.WriteLine("Accept number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(num1))
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
        }

            static bool IsPrime(int number)
            {
                if ((number != 1)||(number == 2) || (number == 3) || (number == 5) || (number == 7) || (number == 9))
                    return true;

                if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) &&
                    (number % 7 != 0) && (number % 9 != 0) && (number % 4 != 0) &&
                    (number % 6 != 0))
                    return true;

                return false;
            }
    }
}
