using System;

namespace _6.Four_Digit_Numbers
{
    class FourDigitNumbers
    {
        static void Main()
        {
            int first = 2011;
            int a = ((first / 1000) % 10);
            int b = ((first / 100) % 10);
            int c = ((first / 10) % 10);
            int d = first % 10;
            Console.WriteLine("The sum of digit is {0}", (a + b + c + d));
            Console.WriteLine("The number in reversed order \"dcba\" is {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("The last digit in the first position \"dabc\" is {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Exchanges the second and the third digits \"acbd\" is {0}{1}{2}{3}", a, c, b, d);

            int second = 3333;
            int aa = ((second / 1000) % 10);
            int bb = ((second / 100) % 10);
            int cc = ((second / 10) % 10);
            int dd = second % 10;
            Console.WriteLine("The sum of digit is {0}", (aa + bb + cc + dd));
            Console.WriteLine("The number in reversed order \"dcba\" is {0}{1}{2}{3}", dd, cc, bb, aa);
            Console.WriteLine("The last digit in the first position \"dabc\" is {0}{1}{2}{3}", dd, aa, bb, cc);
            Console.WriteLine("Exchanges the second and the third digits \"acbd\" is {0}{1}{2}{3}", aa, cc, bb, dd);

            int third = 9876;
            int aaa = ((third / 1000) % 10);
            int bbb = ((third / 100) % 10);
            int ccc = ((third / 10) % 10);
            int ddd = third % 10;
            Console.WriteLine("The sum of digit is {0}", (aaa + bbb + ccc + ddd));
            Console.WriteLine("The number in reversed order \"dcba\" is {0}{1}{2}{3}", ddd, ccc, bbb, aaa);
            Console.WriteLine("The last digit in the first position \"dabc\" is {0}{1}{2}{3}", ddd, aaa, bbb, ccc);
            Console.WriteLine("Exchanges the second and the third digits \"acbd\" is {0}{1}{2}{3}", aaa, ccc, bbb, ddd);

        }
    }
}
