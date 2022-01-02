using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries));

            for (int i = 0; i < (list.Count / 2); i++)
            {
                string first = list[i];
                string last = list[list.Count - i - 1];
                list.RemoveAt(list.Count - i - 1);
                list.RemoveAt(i);
                list.Insert(list.Count - i , first);
                list.Insert(i, last);
            }

            List<int> newList = new List<int>();
            foreach (var index in list)
            {
                newList.AddRange(index.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
