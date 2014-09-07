using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Beer_time
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time:");
            DateTime beer = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(beer);

            DateTime startTime = DateTime.Parse("01:00:00 PM");
            DateTime endTime = DateTime.Parse("02:59:59 AM");

            if ((beer >= startTime) || (beer <= endTime)) 
            {
                Console.WriteLine("It is BEER Time!");
            }
            else
            {
                Console.WriteLine("It is not beer time.");
            }
	
        }
    }
}
