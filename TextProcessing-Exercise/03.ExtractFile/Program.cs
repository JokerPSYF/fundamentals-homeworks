using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");
            string[] extract = path[path.Length - 1].Split(".");
            Console.WriteLine($"File name: {extract[0]}");
            Console.WriteLine($"File extension: {extract[1]}");
        }
    }
}
