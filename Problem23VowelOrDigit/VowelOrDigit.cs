using System;

namespace Problem23VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());
            Vowel(letter);
        }
        static void Vowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (Char.IsNumber(letter))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
