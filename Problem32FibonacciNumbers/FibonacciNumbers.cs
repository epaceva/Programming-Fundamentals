using System;

namespace Problem32FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
                Console.WriteLine(FibonacciNumber(n));
            
        }
        static int FibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
