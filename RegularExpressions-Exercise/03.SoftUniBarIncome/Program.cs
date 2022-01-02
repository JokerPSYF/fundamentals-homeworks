using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Regex regex =
                new Regex
                (@"%(?<name>[A-z][a-z]+)%[^|$%.]*<(?<food>[\w]+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+[.]?[\d]+)?\$");

            string line = Console.ReadLine();

            while (line != "end of shift")
            {
                if (regex.IsMatch(line))
                {
                    Match result = regex.Match(line);
                    string name = result.Groups["name"].Value;
                    string food = result.Groups["food"].Value;
                    double amount = int.Parse(result.Groups["count"].Value) * double.Parse(result.Groups["price"].Value);

                    total += amount;

                    Console.WriteLine($"{name}: {food} - {amount:f2}");
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
