using System;
using System.Collections.Generic;

namespace Problem25MasterNumbers
{
    class MasterNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if(IsSymmetric(i) == true && SumOfDigits(i) == true && ContainsEvenDigit(i) == true )
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsSymmetric( int num)
        {
            int a = num;
            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return (a == rev);
            
        }
        static bool SumOfDigits(int num)
        {
            int  sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return (sum % 7 == 0);
        }
        static bool ContainsEvenDigit(int num)
        {
            int a = 0;
            int b = 0;
            while (num != 0)
            {
                a = num % 10;
                num /= 10;
                if (a % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
