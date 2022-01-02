using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItem = new Dictionary<string, int>() { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            while (true)
            {
                string[] line = Console.ReadLine().ToLower().Split();
                for (int i = 1; i < line.Length; i += 2)
                {
                    int quantity = int.Parse(line[i - 1]);
                    if (line[i] == "shards" || line[i] == "fragments" || line[i] == "motes")
                    {
                        legendaryItem[line[i]] += quantity;
                    }
                    else if (junk.ContainsKey(line[i]))
                    {
                        junk[line[i]] += quantity;
                    }
                    else
                    {
                        junk.Add(line[i], quantity);
                    }


                    if (legendaryItem["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        legendaryItem["shards"] -= 250;
                        foreach (var item in legendaryItem.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }

                        foreach (KeyValuePair<string, int> item in junk.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }

                        return;
                    }
                    else if (legendaryItem["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        legendaryItem["fragments"] -= 250;
                        foreach (var item in legendaryItem.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }

                        foreach (KeyValuePair<string, int> item in junk.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }

                        return;
                    }
                    else if (legendaryItem["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        legendaryItem["motes"] -= 250;
                        foreach (var item in legendaryItem.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }

                        foreach (KeyValuePair<string, int> item in junk.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }

                        return;
                    }
                }

            }
        }
    }
}
