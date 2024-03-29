﻿using System;

class ConvertNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number with range (from 0 to 999):");
        int numInt = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        bool checkNum1 = ((numInt < 0) || (numInt > 999));

        while (checkNum1)
        {
            Console.WriteLine("Invalid range!");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the number with range (from 0 to 999):");
            numInt = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            checkNum1 = ((numInt < 0) || (numInt > 999));
        }
        int hundredsInt = numInt / 10;

        int remainderHundreds = numInt % 10;

        int tensInt = hundredsInt / 10;

        int remainderTens = hundredsInt % 10;

        int unitsInt = tensInt / 10;

        int remainderUnits = tensInt % 10;

        int choiceUnits = 0;
        int choiceTens = 0;
        int choiceHundreds = 0;

        bool devisorHundreds = (hundredsInt == 0);
        bool devisorTens = (tensInt == 0);
        bool devisorUnits = (unitsInt == 0);

        bool checkRemainder1 = ((remainderHundreds == 0) && (remainderTens == 0) && (remainderUnits != 0));
        bool checkRemainder2 = ((remainderHundreds == 0) && (remainderTens != 0) && (remainderUnits != 0));
        bool checkRemainder3 = ((remainderHundreds != 0) && (remainderTens != 0) && (remainderUnits != 0));
        bool checkRemainder4 = ((remainderHundreds != 0) && (remainderTens == 0) && (remainderUnits != 0));

        bool checkNum3 = ((numInt >= 10) && (numInt <= 19));

        bool checkNum2 = (numInt > 19);

        if (devisorHundreds)
        {
            choiceUnits = numInt; //0-9
        }
        else if (devisorTens)
        {
            if (checkNum3)
            {
                choiceUnits = (remainderTens * 10) + remainderHundreds; // 10-19
            }
            else if (checkNum2)
            {
                choiceTens = remainderTens * 10; //20,30,40,50,60,70,80,90
                choiceUnits = remainderHundreds;
            }
        }
        else if (devisorUnits)
        {
            if (checkRemainder1)
            {
                choiceHundreds = 10 * hundredsInt; //100,200,300,400,500,600,700,800,900
            }
            else if (checkRemainder2)
            {
                choiceHundreds = 100 * remainderUnits;  //110,120,130,140,150,160,170,180,190...990
                choiceTens = 10 * remainderTens;
                choiceUnits = 10 * remainderTens;
            }
            else if (checkRemainder3 || checkRemainder4)
            {

                if (checkRemainder4)
                {
                    choiceHundreds = 100 * remainderUnits;//101-109...201-209...501-509...901-909
                    choiceUnits = remainderHundreds;
                }
                else if (checkRemainder3)
                {
                    choiceHundreds = 100 * remainderUnits;//121-129...191-199...921-929...991-999
                    choiceTens = 10 * remainderTens;
                    if (remainderTens <= tensInt)
                    {
                        choiceUnits = (remainderTens * 10) + remainderHundreds;
                    }
                    else
                    {
                        choiceUnits = remainderHundreds;
                    }
                }
            }
        }
        switch (choiceHundreds)
        {
            case 100: Console.Write("One hundred");
                break;
            case 200: Console.Write("Two hundred");
                break;
            case 300: Console.Write("Three Hundred");
                break;
            case 400: Console.Write("Four hundred");
                break;
            case 500: Console.Write("Five hundred");
                break;
            case 600: Console.Write("Six hundred");
                break;
            case 700: Console.Write("Seven hundred");
                break;
            case 800: Console.Write("Eight hundred");
                break;
            case 900: Console.Write("Nine hundred");
                break;
        }
        bool checkAnd = ((choiceHundreds >= 100) && (choiceTens >= 0) && (choiceUnits >= 0));
        if (checkAnd)
        {
            Console.Write(" " + "and" + " ");
        }
        else
        {
            Console.Write(" ");
        }
        switch (choiceTens)
        {
            case 20: Console.Write("Twenty ");
                break;
            case 30: Console.Write("Thirty ");
                break;
            case 40: Console.Write("Forty ");
                break;
            case 50: Console.Write("Fifty ");
                break;
            case 60: Console.Write("Sixty");
                break;
            case 70: Console.Write("Seventy ");
                break;
            case 80: Console.Write("Eighty ");
                break;
            case 90: Console.Write("Ninety ");
                break;
        }
        bool checkChoice1 = ((choiceHundreds >= 100) && (choiceTens >= 0) && (choiceUnits == 0));
        bool checkChoice2 = ((choiceHundreds < 100) && (choiceTens > 0) && (choiceUnits == 0));

        if (checkChoice1)
        {
            choiceUnits = -1;

        }
        else if (checkChoice2)
        {
            choiceUnits = -1;
        }
        switch (choiceUnits)
        {
            case 0: Console.Write("Zero");
                break;
            case 1: Console.Write("One");
                break;
            case 2: Console.Write("Two");
                break;
            case 3: Console.Write("Three");
                break;
            case 4: Console.Write("Four");
                break;
            case 5: Console.Write("Five");
                break;
            case 6: Console.Write("Six");
                break;
            case 7: Console.Write("Seven");
                break;
            case 8: Console.Write("Eight");
                break;
            case 9: Console.Write("Nine");
                break;
            case 10: Console.Write("Ten");
                break;
            case 11: Console.Write("Eleven");
                break;
            case 12: Console.Write("Twelve");
                break;
            case 13: Console.Write("Thirteen");
                break;
            case 14: Console.Write("Fourteen");
                break;
            case 15: Console.Write("Fifteen");
                break;
            case 16: Console.Write("Sixteen");
                break;
            case 17: Console.Write("Seventeen");
                break;
            case 18: Console.Write("Eighteen");
                break;
            case 19: Console.Write("Nineteen");
                break;
        }
        Console.WriteLine("\n");

    }

}