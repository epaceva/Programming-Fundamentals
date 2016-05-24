using System;
using System.Numerics;

namespace Problem36Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Factoriel(n);
        }
        static void Factoriel(BigInteger n)
        {
            BigInteger result = n;

            for (int i = 1; i < n; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
