using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
