using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> atackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            Regex regex =
                new Regex(
                    @"@(?<planet>[A-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<type>[A|D])![^@\-!:>]*->(?<soldiers>[\d]+)");

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                StringBuilder encrypted = new StringBuilder(Console.ReadLine());
                int count = 0;
                for (int j = 0; j < encrypted.Length; j++)
                {
                    switch (encrypted[j])
                    {
                        case 'S':
                        case 'T':
                        case 'A':
                        case 'R':
                        case 's':
                        case 't':
                        case 'a':
                        case 'r':
                            count++;
                            break;
                    }
                }

                StringBuilder decrypted = new StringBuilder();

                for (int k = 0; k < encrypted.Length; k++)
                {
                    char decryptedChar = Convert.ToChar(encrypted[k] - count);
                    decrypted.Append(decryptedChar);
                }

                bool isMatch = regex.IsMatch(decrypted.ToString());
                if (isMatch)
                {
                    var result = regex.Match(decrypted.ToString());
                    string planet = result.Groups["planet"].Value;
                    string type = result.Groups["type"].Value;
                    switch (type)
                    {
                        case "A":
                            atackedPlanets.Add(planet);
                            break;
                        case "D":
                            destroyedPlanets.Add(planet);
                            break;
                    }
                }

            }

            Console.WriteLine($"Attacked planets: {atackedPlanets.Count}");
            if (atackedPlanets.Count > 0)
            {
                foreach (string planet in atackedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (string planet in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
