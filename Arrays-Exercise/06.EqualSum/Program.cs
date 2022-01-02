using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSide = 0;
                int RightSide = 0;
                for (int j = i - 1; j >=  0; j--)
                {
                    leftSide += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    RightSide += arr[k];
                }

                if (leftSide == RightSide)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");

        }
    }
}
