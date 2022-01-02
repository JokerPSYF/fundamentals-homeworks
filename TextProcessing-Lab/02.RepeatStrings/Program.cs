using System;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            foreach (string s in line)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s);
                }
            }
        }
    }
}
