using System;

namespace Problem31NumbersInReversedOrder
{
    class ReversedOrder
    {
        static void Main()
        {
            decimal d = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(d));
        }

        static decimal ReverseNumber(decimal number)
        {
            return decimal.Parse(ReverseString(number.ToString()));
        }

        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
