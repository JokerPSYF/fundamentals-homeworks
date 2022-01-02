using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums = new List<int>(nums.OrderByDescending(x => x));
            for (int i = 0; i < 3; i++)
            {
                if (nums.Count > i)
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
