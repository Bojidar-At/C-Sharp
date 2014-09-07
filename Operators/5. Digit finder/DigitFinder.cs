using System;

namespace _5.Digit_finder
{
    class DigitFinder
    {
        static void Main()
        {
            int a = 5;
            bool cekA = (((a / 100)%10)==7);
            Console.WriteLine(cekA);

            int b = 701;
            bool cekB = (((b / 100) % 10) == 7);
            Console.WriteLine(cekB);

            int c = 9703;
            bool cekC = (((c / 100) % 10) == 7);
            Console.WriteLine(cekC);

            int d = 877;
            bool cekD = (((d / 100) % 10) == 7);
            Console.WriteLine(cekD);

            int e = 777877;
            bool cekE = (((e / 100) % 10) == 7);
            Console.WriteLine(cekE);

            int f = 9999799;
            bool cekF = (((f / 100) % 10) == 7);
            Console.WriteLine(cekF);

            int g = 0;
            bool cekG = (((g / 100) % 10) == 7);
            Console.WriteLine(cekG);
        }
    }
}
