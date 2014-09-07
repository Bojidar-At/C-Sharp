using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum_of_Five_Num
{
    class SumOfFiveNum
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = input.Replace(',', '.');
            decimal sum = 0.00m;
            string[] numbersAsStrings = input.Split(' ');
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                sum += decimal.Parse(numbersAsStrings[i]);
            }
            Console.WriteLine(sum);

        }
    }
}
