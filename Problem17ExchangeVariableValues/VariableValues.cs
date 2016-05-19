using System;

namespace Problem17ExchangeVariableValues
{
    class VariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}", b);

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", b);
            Console.WriteLine("b = {0}",a);
        }
    }
}
