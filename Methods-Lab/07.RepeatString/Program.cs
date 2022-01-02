using System;

namespace _07.RepeatString
{
    class Program
    {
        private static string MultiplyWord(string word, int multiplyer)
        {
            string result = string.Empty;
            for (int i = 0; i < multiplyer; i++)
            {
                result += word;
            }

            return result;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyWord(str, repeat));
        }
    }
}
