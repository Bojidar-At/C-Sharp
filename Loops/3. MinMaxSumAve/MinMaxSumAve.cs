using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MinMaxSumAve
{
    class MinMaxSumAve
    {
        static void Main()
        {
            Console.WriteLine("How many number will be used:");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            int max = 0;
            int min = 0;
            double ave = 0;
            Console.WriteLine("Please enter a numbers:");
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                min = Math.Min(min, number);
 
                //max
                max = Math.Max(max, number);
 
                //sum
                sum += number;
 
                //avg
                ave = Convert.ToDouble(sum / n);
            }
 
                Console.WriteLine("Min = " + min);
                Console.WriteLine("Max = " + max);
                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Avg = {0:F2}", ave);
            
        }
    }
}
