using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexForNames = new Regex(@"(?<name>[A-Za-z])");
            Regex regexForDigits = new Regex(@"(?<digit>\d)");
            Dictionary<string, int> raiders = new Dictionary<string, int>();

            List<string> names = new List<string>(Console.ReadLine().Split(", "));

            string code = Console.ReadLine();

            while (code != "end of race")
            {
                var decodedName = regexForNames.Matches(code);
                var decodedDigit = regexForDigits.Matches(code);

                int kilometers = 0;
                string name = string.Join("", decodedName);
                string digits = string.Join("", decodedDigit);

                for (int i = 0; i < digits.Length; i++)
                {
                    kilometers += int.Parse(digits[i].ToString());
                }

                if (names.Contains(name))
                {
                    if (raiders.ContainsKey(name))
                    {
                        raiders[name] += kilometers;
                    }
                    else
                    {
                        raiders.Add(name, kilometers);
                    }
                }

                code = Console.ReadLine();
            }

            var winners = raiders.OrderByDescending(x => x.Value).Take(3);
            var first = winners.OrderByDescending(x => x.Value).Take(1);
            var second = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var third = winners.OrderBy(x => x.Value).Take(1);
            foreach (var f in first)
            {
                Console.WriteLine($"1st place: {f.Key}");
            }

            foreach (var s in second)
            {
                Console.WriteLine($"2nd place: {s.Key}");
            }

            foreach (KeyValuePair<string, int> t in third)
            {
                Console.WriteLine($"3rd place: {t.Key}");
            }
        }
    }
}
