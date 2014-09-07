using System;

namespace _2.Company_Information
{
    class CompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web Site: ");
            string webSite = Console.ReadLine();

            Console.Write("Manager first name: ");
            string managerFirst = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLast = Console.ReadLine();
            Console.Write("Manager age: ");
            sbyte managerAge = sbyte.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Company: {0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Phone: {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine();
            Console.WriteLine("Manager: {0} {1}", managerFirst, managerLast);
            Console.WriteLine("Age: {0}", managerAge);
            Console.WriteLine("Phone: {0}", managerPhone);

         }
    }
}
