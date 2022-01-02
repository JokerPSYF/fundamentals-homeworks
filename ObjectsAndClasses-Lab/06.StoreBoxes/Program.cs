using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity{ get; set; }
            public decimal PriceForBox { get; set; }
        }
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();

            while (line[0] != "end")
            {
                string serialNumber = line[0];
                string itemName = line[1];
                int itemQuantity = int.Parse(line[2]);
                decimal itemPrice = decimal.Parse(line[3]);
                decimal priceOfBox = itemPrice * (decimal)itemQuantity;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.PriceForBox = priceOfBox;

                box.Item.Name = itemName;
                box.Item.Price = itemPrice;

                boxes.Add(box);


                line = Console.ReadLine().Split();
            }

            var newBoxes = boxes.OrderByDescending(b => b.PriceForBox);
            foreach (Box box in newBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }

        
    }
}
