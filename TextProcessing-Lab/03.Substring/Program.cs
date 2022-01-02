using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string delete = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(delete))
            {
                int index = word.IndexOf(delete);
                word = word.Remove(index, delete.Length);
            }

            Console.WriteLine(word);
        }
    }
}
