using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            //for (int i = 0; i <= line.Length; i++)
            //{
            //    if (line[i] == line[i + 1])
            //    {
            //        line = line.Remove(line[i]);
            //        i--;
            //    }
            //}
            for (int i = line.Length - 1 ; i > 0; i--)
            {
                if (line[i] != line[i-1])
                {
                    result.Insert(0, line[i]);
                }   
            }

            result.Insert(0, line[0]);

            Console.WriteLine(result);
        }
    }
}
