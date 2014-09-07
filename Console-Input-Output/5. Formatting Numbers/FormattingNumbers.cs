using System;

namespace _5.Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            int numFirst = int.Parse(inputLine);
            if ((numFirst>=0)&&(numFirst<=500))
            {

            string binary = Convert.ToString(numFirst, 2);

            inputLine = Console.ReadLine();
            double numTwo = double.Parse(inputLine);

            inputLine = Console.ReadLine();
            double numThird = double.Parse(inputLine);

            Console.WriteLine("{0,-10:X}{1,-10}{2,10:0.##}{3,-10:0.###}", numFirst,
            (binary.PadLeft(10, '0')), numTwo, numThird);            
            }
            else
            {
            Console.WriteLine("The first number is incorect!");
            }
                        
        }
    }
}
