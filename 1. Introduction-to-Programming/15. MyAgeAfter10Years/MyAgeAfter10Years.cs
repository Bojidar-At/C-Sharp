using System;
namespace Introduction_to_Programming
{
    class MyAgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            int age = Int32.Parse(Console.ReadLine());
            if (age > 0 && age < 130)
            {
                Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
            }

            else
            {
                Console.WriteLine("Uncorrect age!");
            }
        }
    }
}
