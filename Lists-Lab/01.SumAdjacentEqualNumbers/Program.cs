using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    double tempN = nums[i + 1] * 2;
                    nums.RemoveAt(i);
                    nums.RemoveAt(i);
                    nums.Insert(i, tempN);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
