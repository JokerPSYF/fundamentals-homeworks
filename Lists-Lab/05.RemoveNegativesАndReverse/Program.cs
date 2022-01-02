using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesАndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            bool isEmpty = IsEmpty(list);
            if (isEmpty)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < list.Count / 2; i++)
                {
                    int temp = list[i];
                    list[i] = list[list.Count - i - 1];
                    list[list.Count - 1 - i] = temp;
                }

                Console.WriteLine(string.Join(" ", list));
            }
        }

        private static bool IsEmpty(List<int> list)
        {
            if (list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
