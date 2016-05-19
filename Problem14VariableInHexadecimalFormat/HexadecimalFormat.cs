using System;

namespace Problem14VariableInHexadecimalFormat
{
    class HexadecimalFormat
    {
        static void Main()
        {
            string n = Console.ReadLine();
            int decValue = Convert.ToInt32(n, 16);
            Console.WriteLine(decValue);
        }
    }
}
    