using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> oddCount = new Dictionary<string, int>();

            foreach (string word in line)
            {
                if (oddCount.ContainsKey(word))
                {
                    oddCount[word]++;
                }
                else
                {
                    oddCount.Add(word, 1);
                }
            }

            foreach (var word in oddCount)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }

        }
    }
}
