using System;

namespace Problem1CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            double years = centuries * 100;
            double days =  Math.Round(years * 365.242199);
            double hours = days * 24;
            double minutes = hours * 60;


            Console.WriteLine(centuries);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);

        }
    }
}
