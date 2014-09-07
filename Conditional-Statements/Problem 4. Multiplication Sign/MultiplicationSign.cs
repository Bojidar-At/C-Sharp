using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write three number: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if((a==0)||(b==0)||(c==0))
            {
                Console.WriteLine("0");
            }
            else if((a<0)&&(b>0)&&(c>0))
            {
                Console.WriteLine("-");
            }
            else if ((a > 0) && (b< 0) && (c > 0))
            {
                Console.WriteLine("-");
            }
            else if ((a > 0) && (b > 0) && (c < 0))
            {
                Console.WriteLine("-");
            }
            else if ((a < 0) && (b < 0) && (c < 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
