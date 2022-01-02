using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                if (line[0] == "register")
                {
                    string user = line[1];
                    string plate = line[2];
                    if (register.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[user]}");
                    }
                    else
                    {
                        register.Add(user, plate);
                        Console.WriteLine($"{user} registered {register[user]} successfully");
                    }
                }
                else
                {
                    string user = line[1];
                    if (!register.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        register.Remove(user);
                    }
                }
            }

            foreach (KeyValuePair<string, string> user in register)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
