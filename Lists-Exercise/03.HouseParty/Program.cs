using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listParty = new List<string>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[2] == "going!")
                {
                    if (!listParty.Contains(command[0]))
                    {
                        listParty.Add(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                }
                else
                {
                    if (listParty.Contains(command[0]))
                    {
                        listParty.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
                
            }

            Console.WriteLine(String.Join("\n", listParty));
        }
    }
}
