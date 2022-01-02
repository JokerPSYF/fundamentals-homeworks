using System;
using System.Linq;

namespace _08.CondenseArrayТoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numsLength = nums.Length;


            while (numsLength > 1)
            {
                int[] condensed = new int[numsLength - 1];
                for (int i = 0; i < numsLength - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
                numsLength--;


            }


            Console.WriteLine(nums[0]);
        }
    }
}