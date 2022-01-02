using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstArray[i] = number;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(firstArray[i] + " ");
            }
        }
    }
}
