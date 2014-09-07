using System;

namespace _6.Strings_and_Objects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string greats = "Hello";
            string place = "World";
            object greatsPlace = greats + " " + place;
            Console.WriteLine(greatsPlace);

            string helloWorld = (string)greatsPlace;
            Console.WriteLine(helloWorld);
        }
    }
}
