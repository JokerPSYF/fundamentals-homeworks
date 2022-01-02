using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            Console.WriteLine(VowelCount(word));
        }

        private static int VowelCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'u':
                    case 'i':
                        count++;
                        break;
                }
            }

            return count;
        }
    }
}
