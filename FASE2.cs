using System;

namespace FASE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int YEAR = 1948;
            int leap = 4;
            int quantity = (1997 - YEAR) / leap;

            Console.WriteLine(quantity);
        }
    }
}
