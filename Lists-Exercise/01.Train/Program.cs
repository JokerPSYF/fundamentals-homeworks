using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int limit = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int people = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + people <= limit)
                        {
                            int temp = wagons[i] + people;
                            wagons.RemoveAt(i);
                            wagons.Insert(i, temp);
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
