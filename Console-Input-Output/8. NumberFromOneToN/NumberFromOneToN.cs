using System;

class SumOfNNumbers
{
    static void Main()
    {
        int numbersInput = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < numbersInput; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            sum += numbers;
            
        }
        Console.WriteLine(sum);
    }
}
