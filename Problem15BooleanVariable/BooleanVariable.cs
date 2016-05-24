using System;

namespace Problem15BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            string a = Console.ReadLine();
            IsBoool(a);
        }
        static void IsBoool(string b)
        {
            if (b == "True")
            {
                Console.WriteLine(("Yes"));
            }
            else 
            {
                Console.WriteLine(("No"));
            }
        }
    }
}
