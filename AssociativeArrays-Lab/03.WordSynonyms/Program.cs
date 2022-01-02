using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsSynonym = new Dictionary<string, List<string>>();

            for (int i = 0; i < n ; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordsSynonym.ContainsKey(word))
                {
                    wordsSynonym[word].Add(synonym);
                }
                else
                {
                    wordsSynonym.Add(word, new List<string>() { synonym });
                }

            }
            foreach (KeyValuePair<string, List<string>> keyValuePair in wordsSynonym)
            {
                Console.WriteLine($"{keyValuePair.Key} - {string.Join(", ", keyValuePair.Value)}");
            }
        }
    }
}
