using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestCount = int.MinValue;
            int biggestStartIndex = 0;
            int biggestLastIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        int startIndex = i;
                        int lastIndex = j;
                        count++;
                    }
                    else
                    {

                        count = 0;
                        break;
                    }
                    if (count > biggestCount)
                    {
                        biggestCount = count;
                        biggestStartIndex = i;
                        biggestLastIndex = j;
                    }

                }


            }

            for (int i = biggestStartIndex; i <= biggestLastIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
