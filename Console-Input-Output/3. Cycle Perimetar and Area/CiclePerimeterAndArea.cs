using System;

namespace _3.Cycle_Perimetar_and_Area
{
    class CiclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Radius of Cicle is: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of Cicle is: {0:#.##}", (2*r*Math.PI));
            Console.WriteLine("The area of Cicle is: {0:#.##}", (r*r*Math.PI));
        }
    }
}
