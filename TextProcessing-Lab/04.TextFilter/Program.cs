using System;
using System.Text;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            StringBuilder line = new StringBuilder(Console.ReadLine());
            foreach (string word in bannedWords)
            {
                string star = new string((char)'*', word.Length);
                line.Replace(word, star);
            }

            Console.WriteLine(line);
        }
    }
}
