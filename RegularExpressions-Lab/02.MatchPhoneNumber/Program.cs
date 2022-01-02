using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";

            string phones = Console.ReadLine();

            MatchCollection phoneCollection = Regex.Matches(phones, regex);

            var phoneCatch = phoneCollection.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", phoneCatch));
        }
    }
}
