using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int length = myList.Count;
            for (int i = 0; i < length / 2; i++)
            {
                int sum = myList[myList.Count - 1] + myList[i];
                myList.RemoveAt(i);
                myList.RemoveAt(myList.Count - 1);
                myList.Insert(i, sum);
            }

            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
