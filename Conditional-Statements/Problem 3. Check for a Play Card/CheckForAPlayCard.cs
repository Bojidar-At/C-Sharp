﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Check_for_a_Play_Card
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a card sign:");

            string a = Convert.ToString(Console.ReadLine());
            switch (a)
            {
                case "2":

                case "3":

                case "4":

                case "5":

                case "6":

                case "7":

                case "8":

                case "9":

                case "10":

                case "J":

                case "Q":

                case "K":

                case "A":

                    Console.WriteLine("yes");
                    break;
                default:
                    Console.WriteLine("no");
                    break;

            }
        }
    }
}
