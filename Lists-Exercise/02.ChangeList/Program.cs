using System;
using System.Collections.Generic;
using System.Linq;
using static System.Int32;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int num = int.Parse(command[1]);
                    list.RemoveAll(item => item == num);
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}