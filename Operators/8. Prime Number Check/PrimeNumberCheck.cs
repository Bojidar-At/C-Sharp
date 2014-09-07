using System;

namespace _8.Prime_Number_Check
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int a1 = 1;
            bool checkA1 = ((a1 == 2)||(a1 == 3)||(a1 == 5)||(a1 == 7))||((a1%2 != 0)&&(a1%3 !=0)&&(a1%5 !=0))&&(a1 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a1, checkA1);

            int a2 = 2;
            bool checkA2 = ((a2 == 2) || (a2 == 3) || (a2 == 5) || (a2 == 7)) || ((a2 % 2 != 0) && (a2 % 3 != 0) && (a2 % 5 != 0)) && (a2 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a2, checkA2);

            int a3 = 3;
            bool checkA3 = ((a3 == 2) || (a3 == 3) || (a3 == 5) || (a3 == 7)) || ((a3 % 2 != 0) && (a3 % 3 != 0) && (a3 % 5 != 0)) && (a3 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a3, checkA3);

            int a4 = 4;
            bool checkA4 = ((a4 == 2) || (a4 == 3) || (a4 == 5) || (a4 == 7)) || ((a4 % 2 != 0) && (a4 % 3 != 0) && (a4 % 5 != 0)) && (a4 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a4, checkA4);

            int a5 = 9;
            bool checkA5 = ((a5 == 2) || (a5 == 3) || (a5 == 5) || (a5 == 7)) || ((a5 % 2 != 0) && (a5 % 3 != 0) && (a5 % 5 != 0)) && (a5 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a5, checkA5);

            int a6 = 97;
            bool checkA6 = ((a6 == 2) || (a6 == 3) || (a6 == 5) || (a6 == 7)) || ((a6 % 2 != 0) && (a6 % 3 != 0) && (a6 % 5 != 0)) && (a6 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a6, checkA6);

            int a7 = 51;
            bool checkA7 = ((a7 == 2) || (a7 == 3) || (a7 == 5) || (a7 == 7)) || ((a7 % 2 != 0) && (a7 % 3 != 0) && (a7 % 5 != 0)) && (a7 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a7, checkA7);

            int a8 = -3;
            bool checkA8 = ((a8 == 2) || (a8 == 3) || (a8 == 5) || (a8 == 7)) || ((a8 % 2 != 0) && (a8 % 3 != 0) && (a8 % 5 != 0)) && (a8 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a8, checkA8);

            int a9 = 0;
            bool checkA9 = ((a9 == 2) || (a9 == 3) || (a9 == 5) || (a9 == 7)) || ((a9 % 2 != 0) && (a9 % 3 != 0) && (a9 % 5 != 0)) && (a9 != 1);
            Console.WriteLine("The number {0} is prime: {1}", a9, checkA9);
        }
    }
}
