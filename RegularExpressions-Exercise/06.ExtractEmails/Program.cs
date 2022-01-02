using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexUser = new Regex(@"(^|\s)[A-Za-z\d+][\w*\-\.]*[A-Za-z\d+]@[A-Za-z]+([.-][A-Za-z]+)+\b");
            string line = Console.ReadLine();

            MatchCollection emails = regexUser.Matches(line);

            if (emails.Count > 0)
            {
                foreach (Match match in emails)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
