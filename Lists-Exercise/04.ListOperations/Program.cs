using System;
using System.Collections.Generic;
using System.Linq;
using static System.Int32;

namespace _01.Train
{
    class Program
    {
        //Add {number} – add the given number to the end of the list
        //Insert {number}{ index} – insert the number at the given index
        //Remove {index} – remove the number at the given index
        //Shift left {count} – first number becomes last. This has to be repeated the specified number of times
        //Shift right {count} – last number becomes first. To be repeated the specified number of times
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) < list.Count && int.Parse(command[2]) >= 0)
                    {
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) < list.Count && int.Parse(command[1]) >= 0)
                    {
                        list.RemoveAt(int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Shift")
                {
                    command = ListManipulation(command, list);
                }
                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static string[] ListManipulation(string[] command, List<int> list)
        {
            int laps = int.Parse(command[2]);
            if (command[1] == "left")
            {

                for (int i = 0; i < laps; i++)
                {
                    int temp = list[0];
                    list.RemoveAt(0);
                    list.Add(temp);
                }
            }
            else if (command[1] == "right")
            {
                for (int i = 0; i < laps; i++)
                {
                    int temp = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                    list.Insert(0, temp);
                }
            }
            return command;
        }
    }
}