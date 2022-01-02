using System;

namespace _05.Orders
{
    class Program
    {
        static void howMuchItCost(string product, int quantity)
        {
            double sum = 0;

            switch (product)
            {
                case "coffee":
                    sum = 1.50 * quantity;
                    break;
                case "water":
                    sum = 1.00 * quantity;
                    break;
                case "coke":
                    sum = 1.40 * quantity;
                    break;
                case "snacks":
                    sum = 2.00 * quantity;
                    break;
            }

            Console.WriteLine($"{sum:f2}");
        }
        static void Main(string[] args)
        {
            //    coffee – 1.50
            //    water – 1.00
            //    coke – 1.40
            //    snacks – 2.00

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            howMuchItCost(product , quantity);
        }
    }
}
