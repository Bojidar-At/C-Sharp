using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the score: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine(a * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(a*100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(a*1000);
                    break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;

            }
        }
    }
}
