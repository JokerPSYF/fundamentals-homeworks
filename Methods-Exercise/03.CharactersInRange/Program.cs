using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            FindTheCharactersBetweenThem(firstChar, secondChar);
        }

        private static void FindTheCharactersBetweenThem(char firstChar, char secondChar)
        {
            if (secondChar < firstChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
