using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fisrtArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < fisrtArray.Length; i++)
            {
                if (fisrtArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

                sum += fisrtArray[i];
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
