using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            List<string> validNames = new List<string>();

            foreach (string name in names)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    bool isNameValid = true;
                    foreach (char letter in name)
                    {
                        if (!(char.IsLetterOrDigit(letter) || letter == '-' || letter == '_'))
                        {
                            isNameValid = false;
                        }
                    }

                    if (isNameValid)
                    {
                        validNames.Add(name);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", validNames));
        }
    }
}
