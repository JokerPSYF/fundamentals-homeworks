using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] evenSum = new int[lines];
            int[] oddSum = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evenSum[i] = firstArr[0];
                    oddSum[i] = firstArr[1];
                }
                else
                {
                    evenSum[i] = firstArr[1];
                    oddSum[i] = firstArr[0];
                }
            }
            //foreach (var evenNum in evenSum)
            //{
            //    Console.Write(evenNum + " ");   
            //}

            //Console.WriteLine();

            //foreach (var oddNum in oddSum)
            //{
            //    Console.Write(oddNum + " ");   
            //}
            Console.WriteLine(String.Join(" ", evenSum));
            Console.WriteLine(String.Join(" ", oddSum));
        }
    }
}
