using System;

namespace Problem10FilledSquare
{
    class FilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", Dash2(2 * n));
            
            for (int i = 0; i < n - 2 ; i++)
            {
                Console.Write("{0}", Dash2(1));
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write("{0}", Dash(1));
                    Console.Write("{0}", Dash1(1));
                }
                Console.WriteLine("{0}", Dash2(1));
            }
            
            Console.WriteLine("{0}", Dash2(2 * n));
        }
        static string Dash(int n)
        {
            return new string('\\', n);
        }
        static string Dash1(int n)
        {
            return new string('/', n);
        }
        static string Dash2(int n)
        {
            return new string('-', n);
        }
    }
}
