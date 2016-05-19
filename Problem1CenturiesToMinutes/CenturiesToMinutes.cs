using System;

namespace Problem1CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int) Math.Round(years * 365.242199);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine(centuries);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}
