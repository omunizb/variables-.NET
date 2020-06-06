using System;

namespace FASE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Oriol";
            string firstSurname = "Muñiz";
            string secondSurname = "Baguena";

            int day, month, year;
            day = 2;
            month = 4;
            year = 1997;

            Console.WriteLine($"{firstSurname} {secondSurname}, {name}");
            Console.WriteLine($"{day} / {month} / {year}");
        }
    }
}
