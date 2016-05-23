using System;

namespace Problem33PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            double number =Convert.ToDouble(n);
            if (isPrime(number))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static bool isPrime(double number)
        {
            double boundary = (double)Math.Floor(Math.Sqrt(number));

            if (number == 1 || number == 0) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
