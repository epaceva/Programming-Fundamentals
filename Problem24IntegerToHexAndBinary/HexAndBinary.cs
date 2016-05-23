using System;

namespace Project24IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string hex = number.ToString("X");
            string bin = Convert.ToString(number, 2);

            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
