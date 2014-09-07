using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Play
{
    class Play
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string
");

            int choose = int.Parse(Console.ReadLine());

            if(choose == 1)
            {
                Console.Write("Please enter a int: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(++a);
            }
            else if(choose == 2)
            {
                Console.Write("Please enter a double: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(++a);
            }
            else
            {
                Console.Write("Please enter a string: ");
                string a = Console.ReadLine();
                Console.WriteLine(a+"*");
            }

        }
    }
}
