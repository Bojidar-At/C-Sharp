using System;

namespace _10.Employars
{
    class Employee
    {
        static void Main()
        {
            string firstName = "Bozhidar";
            string lastName = "Atanasov";
            byte age = 24;
            char gender = 'm';
            long personalIDNumber = 8913326666;
            int emplNumber = 27569999;
            Console.WriteLine("First name: {0} \nLast name: {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0} \nPersonal ID Number: {1} \nUniqe employear number: {2}", gender, personalIDNumber, emplNumber);
         }
    }
}
