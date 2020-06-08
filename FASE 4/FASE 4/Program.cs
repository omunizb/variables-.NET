using System;

namespace FASE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool leapYear = false;
            string yes = "I was born in a leap year";
            string no = "I was not born in a leap year";

            string name, firstSurname, secondSurname;
            name = "Oriol";
            firstSurname = "Muñiz";
            secondSurname = "Baguena";

            int day, month, year;
            day = 2;
            month = 4;
            year = 1997;

            Console.WriteLine($"My name is {name} {firstSurname} {secondSurname}");
            Console.WriteLine($"I was born on {day} / {month} / {year}");

            // Check if bith year was a leap year (Gregorian calendar) 
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                leapYear = true;
            }

            if (leapYear == true)
            {
                Console.WriteLine(yes);
            }
            else
            {
                Console.WriteLine(no);
            }
        }
    }
}
