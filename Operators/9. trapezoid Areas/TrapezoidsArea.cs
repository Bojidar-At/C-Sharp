using System;

namespace _9.trapezoid_Areas
{
    class TrapezoidsArea
    {
        static void Main()
        {
            var a1 = 5;
            var b1 = 7;
            var h1 = 12;
            Console.WriteLine("The first trapezoid`s area is: {0}", ((a1+b1)/2)*h1);

            double a2 = 2;
            double b2 = 1;
            double h2 = 33;
            Console.WriteLine("The first trapezoid`s area is: {0}", ((a2 + b2) / 2) * h2);

            double a3 = 8.5;
            double b3 = 4.3;
            double h3 = 2.7;
            Console.WriteLine("The first trapezoid`s area is: {0}", ((a3 + b3) / 2) * h3);

            double a4 = 100;
            double b4 = 200;
            double h4 = 300;
            Console.WriteLine("The first trapezoid`s area is: {0}", ((a4 + b4) / 2) * h4);

            double a5 = 0.222;
            double b5 = 0.333;
            double h5 = 0.555;
            Console.WriteLine("The first trapezoid`s area is: {0}", ((a5 + b5) / 2) * h5);
                   
        }
    }
}
