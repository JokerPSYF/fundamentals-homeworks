using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();
            for (int i = 0; i < lines.Length; i++)
            {
                int random = rnd.Next(0, lines.Length - 1);
                string temp = lines[i];
                lines[i] = lines[random];
                lines[random] = temp;
            }

            Console.WriteLine(string.Join("\n",lines));
        }
    }
}
