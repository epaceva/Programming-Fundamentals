using System;

namespace Problem5SpecialNumbers
{
    class SpecialNumbers
    {
        int sum;

        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (sumDigits(i) == 5 || sumDigits(i) == 7 || sumDigits(i) == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
        private static int sumDigits(int x)
        {
            int sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
    }
}
