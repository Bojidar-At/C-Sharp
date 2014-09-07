using System;
namespace Introduction_to_Programming
{
    class MembersOfSeqence
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i + 2);
                }
                else
                {
                    Console.Write("{0} ", -(i + 2));
                }
            }
    
        }
    }
}
