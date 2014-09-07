using System;

namespace _7__Point_in_a_Circle
{
    class PointInACircle
    {
        static void Main()
        {
            float x1 = 0;
            float y1 = 1;
            bool xy1 = ((Math.Sqrt(x1*x1+y1*y1)) <= 2);
            Console.WriteLine(xy1);

            float x2 = -2;
            float y2 = 0;
            bool xy2 = ((Math.Sqrt(x2 * x2 + y2 * y2)) <= 2);
            Console.WriteLine(xy2);

            float x3 = -1;
            float y3 = 2;
            bool xy3 = ((Math.Sqrt(x3 * x3 + y3 * y3)) <= 2);
            Console.WriteLine(xy3);

            float x4 = 1.5f;
            float y4 = -1;
            bool xy4 = ((Math.Sqrt(x4 * x4 + y4 * y4)) <= 2);
            Console.WriteLine(xy4);

            float x5 = -1.5f;
            float y5 = -1.5f;
            bool xy5 = ((Math.Sqrt(x5 * x5 + y5 * y5)) <= 2);
            Console.WriteLine(xy5);

            float x6 = 100;
            float y6 = -30;
            bool xy6 = ((Math.Sqrt(x6 * x6 + y6 * y6)) <= 2);
            Console.WriteLine(xy6);

            float x7 = 0;
            float y7 = 0;
            bool xy7 = ((Math.Sqrt(x7 * x7 + y7 * y7)) <= 2);
            Console.WriteLine(xy7);

            float x8 = 0.2f;
            float y8 = -0.8f;
            bool xy8 = ((Math.Sqrt(x8 * x8 + y8 * y8)) <= 2);
            Console.WriteLine(xy8);

            float x9 = 0.9f;
            float y9 = -1.93f;
            bool xy9 = ((Math.Sqrt(x9 * x9 + y9 * y9)) <= 2);
            Console.WriteLine(xy9);

            float x10 = 1;
            float y10 = 1.655f;
            bool xy10 = ((Math.Sqrt(x10 * x10 + y10 * y10)) <= 2);
            Console.WriteLine(xy10);



        }
    }
}
