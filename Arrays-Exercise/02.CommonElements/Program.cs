using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(" ");
            string[] secondArr = Console.ReadLine().Split(" ");

            foreach (var first in firstArr)
            {
                foreach (var second in secondArr)
                {
                    if (first == second)
                    {
                        Console.Write(second + " ");
                    }
                }
            }
        }
    }
}
