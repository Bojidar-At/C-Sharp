using System;
namespace _4.Rectangel
{
    class Rectangles
    {
        static void Main()
        {
            int wightA = 3;
            int heightA = 4;
            Console.WriteLine("The perimetar is {0}", 2*(wightA+heightA));
            Console.WriteLine("The area is {0}", wightA*heightA);

            float wightB = 2.5f;
            int heightB = 3;
            Console.WriteLine("The perimetar is {0}", 2 * (wightB + heightB));
            Console.WriteLine("The area is {0}", wightB * heightB);
        }
    }
}
