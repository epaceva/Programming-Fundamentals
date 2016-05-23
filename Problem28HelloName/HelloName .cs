using System;

namespace Problem28HelloName
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();

            Name(name);
        }
        static void Name(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
