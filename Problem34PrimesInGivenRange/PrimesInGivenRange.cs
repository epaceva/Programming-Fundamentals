using System;
using System.Collections.Generic;

namespace Problem34PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int counter = 0;

            FindPrimesInRange(n, m, counter);
        }
        static void FindPrimesInRange (int startNum, int endNum, int counter)
        {

            List<int> numbers = new List<int>();
            if (startNum < 0 || endNum < 0)
            {
                startNum = 2;
            }
            if (startNum == 0 || startNum == 1)
            {
                startNum = 2;
            }
            if (startNum > endNum)
            {
                Console.WriteLine("Empty list");
            }
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                    if (counter > 2)
                    {
                        break;
                    }
                }
                if (counter <= 2)
                {
                    numbers.Add(i);
                }
                counter = 0;
            }
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                if (i != numbers.Count -1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        
        }
        
    }
}
