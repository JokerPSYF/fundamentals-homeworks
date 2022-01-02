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
            bool isDiference = false;
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        list.Add(int.Parse(command[1]));
                        isDiference = true;
                        break;

                    case "Remove":
                        list.Remove(int.Parse(command[1]));
                        isDiference = true;
                        break;

                    case "RemoveAt":
                        list.RemoveAt(int.Parse(command[1]));
                        isDiference = true;
                        break;

                    case "Insert":
                        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isDiference = true;
                        break;

                    case "Contains":
                        if (list.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 == 0)
                            {
                                Console.Write($"{list[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 == 1)
                            {
                                Console.Write($"{list[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        Console.WriteLine(sum);
                        break;                                                                          //'<', '>', ">=", "<=".

                    case "Filter":
                        switch (command[1])
                        {
                            case "<":
                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (list[i] < int.Parse(command[2]))
                                    {
                                        Console.Write($"{list[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;

                            case ">":
                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (list[i] > int.Parse(command[2]))
                                    {
                                        Console.Write($"{list[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;

                            case ">=":
                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (list[i] >= int.Parse(command[2]))
                                    {
                                        Console.Write($"{list[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;

                            case "<=":
                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (list[i] <= int.Parse(command[2]))
                                    {
                                        Console.Write($"{list[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            if (isDiference)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}