﻿using System;

namespace Problem19ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", c, b, a);

        }
    }
}
