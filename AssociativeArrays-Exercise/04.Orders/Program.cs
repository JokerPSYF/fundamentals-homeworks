using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> catalogue = new Dictionary<string, List<double>>();
            string[] line = Console.ReadLine().Split();
            while (line[0] != "buy")
            {
                string product = line[0];
                double price = double.Parse(line[1]);
                double quantity = double.Parse(line[2]);

                if (catalogue.ContainsKey(product))
                {
                    catalogue[product][1] += quantity;
                    catalogue[product][0] = price;
                }
                else
                {
                    catalogue.Add(product, new List<double>(){price, quantity});
                }

                line = Console.ReadLine().Split();
            }

            foreach (var product in catalogue)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
