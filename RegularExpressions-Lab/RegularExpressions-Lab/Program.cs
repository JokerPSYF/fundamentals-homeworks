using System;
using System.Text.RegularExpressions;

namespace RegularExpressions_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            string names = Console.ReadLine();

            MatchCollection matchedColection = Regex.Matches(names, regex);

            foreach (Match name in matchedColection)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
