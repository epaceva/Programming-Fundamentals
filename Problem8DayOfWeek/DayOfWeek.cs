﻿using System;

namespace Problem8DayOfWeek
{
    class DayOfWeek
    {

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 7)
            {
                WeekDay(number);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static void WeekDay(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    break;
            }
        }
    }
}
