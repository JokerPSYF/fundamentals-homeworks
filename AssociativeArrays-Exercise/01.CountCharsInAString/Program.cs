using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            string word = Console.ReadLine();
            List<char> wordsChars = word.ToCharArray().ToList();

            foreach (char letter in wordsChars)
            {
                if (letter == ' ')
                {
                    
                }
                else if (counts.ContainsKey(letter))
                {
                    counts[letter]++;
                }
                else
                {
                    counts.Add(letter, 1);
                }
            }
            foreach (KeyValuePair<char, int> count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
