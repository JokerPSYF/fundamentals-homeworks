using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleChar(input);
        }

        private static void MiddleChar(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write(input[(input.Length/2) - 1]);
            }
            char middle = input[input.Length / 2];
            Console.Write(middle);
        }
    }
}
