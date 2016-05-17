using System;

namespace Problem3ExactSumOfRealNumbers
{
    class SumOfRealNumbers
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < x; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
