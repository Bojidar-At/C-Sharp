using System;

namespace _11.Bank_Acount
{
    class BankAcount
    {
        static void Main()
        {
            string holder = "Bozhidar Valentinov Atanasov";
            decimal balance = 500354965.65m;
            string bank = "Raiffeisenbank (Bulgaria) JSC";
            object iban = "BG85RZBB91551010202030";
            long cardNumber1 = 4767337140681553;
            long cardNumer2 = 9767337140681553;
            long cardNumer3 = 9999337140681553;

            Console.WriteLine(holder);
            Console.WriteLine(balance);
            Console.WriteLine(bank);
            Console.WriteLine(iban);
            Console.WriteLine(cardNumber1);
            Console.WriteLine(cardNumer2);
            Console.WriteLine(cardNumer3);
        }
    }
}
