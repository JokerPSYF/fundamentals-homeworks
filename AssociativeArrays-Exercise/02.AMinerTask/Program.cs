using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantityOfResources = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (quantityOfResources.ContainsKey(resource))
                {
                    quantityOfResources[resource] += quantity;
                }
                else
                {
                    quantityOfResources.Add(resource, quantity);

                }
                resource = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> valuePair in quantityOfResources)
            {
                Console.WriteLine($"{valuePair.Key} -> {valuePair.Value}");
            }
        }
    }
}
