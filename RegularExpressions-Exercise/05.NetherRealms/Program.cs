using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\d+\+\-\*\/\.\,]";
            string damage = @"-?\d+\.?\d*";
            string multipyAndDivide = @"[\/\*]";
            string split = @"[,\s]+";

            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, split).OrderBy(x => x).ToArray();
            for (int i = 0; i < demons.Length; i++)
            {
                var healthMatches = Regex.Matches(demons[i], healthPattern);
                long health = 0;

                foreach (Match ch in healthMatches)
                {
                    char currChar = char.Parse(ch.ToString());
                    health += currChar;
                }

                double damagePoints = 0;
                MatchCollection points = Regex.Matches(demons[i], damage);
                foreach (Match match in points)
                {
                    damagePoints += double.Parse(match.ToString());
                }

                MatchCollection MandD = Regex.Matches(demons[i], multipyAndDivide);
                foreach (Match match in MandD)
                {
                    char currMach = char.Parse(match.ToString());
                    if (currMach == '*')
                    {
                        damagePoints *= 2;
                    }
                    else
                    {
                        damagePoints /= 2;
                    }
                }

                Console.WriteLine($"{demons[i]} - {health} health, {damagePoints:f2} damage");
            }
        }
    }
}
