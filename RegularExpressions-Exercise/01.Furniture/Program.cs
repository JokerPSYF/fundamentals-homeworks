using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string regex = @">>(?<name>[A-za-z\s]+)<<(?<price>\d+(\.\d+)?)!(?<count>\d+)";
            List<string> furnitures = new List<string>();
            double total = 0;

            while (line != "Purchase")
            {
                var data = Regex.Match(line, regex, RegexOptions.IgnoreCase);
                if (data.Success)
                {

                    var name = data.Groups["name"].Value;
                    var price = double.Parse(data.Groups["price"].Value);
                    var count = int.Parse(data.Groups["count"].Value);

                    total += price * count;
                    furnitures.Add(name);
                }


                line = Console.ReadLine();
            }

            Console.WriteLine($"Bought furniture:");
            if (furnitures.Count > 0)
            {
                Console.WriteLine(string.Join("\n", furnitures));
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
